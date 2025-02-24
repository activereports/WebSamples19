using GrapeCity.ActiveReports.Core.Rendering.Data;
using GrapeCity.ActiveReports.Rendering.DataProcessing;
using System.Collections;
using System.Data.Common;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace WebDesignerCustomDataProviders
{
	public sealed class C1ODataConnectionAdapter : IDbConnectionAdapter, IDbCommandParametersAdapter
    {
		public static C1ODataConnectionAdapter Instance = new C1ODataConnectionAdapter();

        public bool IsCredentialsSupported => false;

        public bool IsSetConnectionStringSupported => false;

        private string MultivalueParameterValueToString(object[] parameterArrayValue)
		{
			return string.Join(",", parameterArrayValue.Select(parameterValue => "'" + Convert.ToString(parameterValue, CultureInfo.InvariantCulture) + "'"));
		}

        private void SetMultiValueParameter(DbCommand command, string parameterName, object[] value)
        {
            var parameterValuesAsString = MultivalueParameterValueToString(value);
            var parameterNamepattern = CreateParameterNamePattern(parameterName);
            Regex parameterReplacement = new Regex(parameterNamepattern, RegexOptions.IgnoreCase);
            command.CommandText = parameterReplacement.Replace(command.CommandText, parameterValuesAsString);
        }

        private static ICollection DisectString(string text)
        {
            ArrayList strings = new ArrayList();
            int nextNonChar = NextNonCharacterIndex(text, 0);
            int nextChar = NextCharacterIndex(text, 0);

            while (text.Length > 0)
            {
                int length = Math.Max(nextNonChar, nextChar);
                if (length >= text.Length)
                {
                    strings.Add(Regex.Escape(text));
                    break;
                }
                strings.Add(Regex.Escape(text.Substring(0, length)));
                text = text.Remove(0, length);
                nextNonChar = NextNonCharacterIndex(text, 0);
                nextChar = NextCharacterIndex(text, 0);
            }
            return strings;
        }


        private static int NextNonCharacterIndex(string text, int index)
        {
            for (int i = index; i < text.Length; i++)
                if (!char.IsLetterOrDigit(text, i) && text[i] != '_')
                    return i;
            return text.Length;
        }

        private static int NextCharacterIndex(string text, int index)
        {
            for (int i = index; i < text.Length; i++)
                if (char.IsLetterOrDigit(text, i) || text[i] == '_')
                    return i;
            return text.Length;
        }

        private string CreateParameterNamePattern(string parameterName)
        {
            var builder = new StringBuilder("(");
            var strings = DisectString(parameterName);
            foreach (string s in strings)
            {
                if (char.IsLetterOrDigit(s, 0))
                {
                    builder.Append("\\b");
                    builder.Append(s);
                    builder.Append("\\b");
                }
                else
                    builder.Append(s);
            }
            builder.Append(")");
            return builder.ToString();
        }

        public void SetParameters(DbCommand command, IEnumerable<DbParameter> queryParameters)
        {
            try
            {
                command.Parameters.Clear();

                foreach (var queryParameter in queryParameters)
                {
                    if (queryParameter.Value is object[] multivalue)
                    {
                        SetMultiValueParameter(command, queryParameter.ParameterName, multivalue);
                        continue;
                    }

                    var param = command.CreateParameter();
                    param.ParameterName = queryParameter.ParameterName;
                    param.Value = queryParameter.Value ?? DBNull.Value;
                    command.Parameters.Add(param);
                }
            }
            catch (NotSupportedException)
            {
                //valid situation when data passed using LocateDataSource
            }
        }

        public void SetCredentials(DbConnection connection, LoginPasswordCredentials credentials)
        {
            throw new NotImplementedException();
        }

        public void SetConnectionString(DbConnection connection, string connectionString, DbConnectionAdapterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
