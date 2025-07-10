using System.Text;

namespace BlazorViewer_CustomStore.Data;

/// <summary>
/// Represents a service that provides data retrieval functionality.
/// </summary>
public class DataService
{
	private readonly Dictionary<string, string> _data = new Dictionary<string, string>()
	{
		{ "AcmeStore.csv", Data.AcmeStore },
		{ "Invoice.csv", Data.Invoice }
	};
	
	/// <summary>
	/// Retrieves the data associated with the specified name.
	/// </summary>
	public string GetData(string name)
	{
		return _data[name];
	}
}