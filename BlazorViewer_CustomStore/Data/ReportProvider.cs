using GrapeCity.ActiveReports.Web.Viewer;

namespace BlazorViewer_CustomStore.Data;

/// <summary>
/// Represents a provider that retrieves reports from a specified directory.
/// </summary>
public class ReportProvider : IReportProvider
{
	private readonly DirectoryInfo _reportsDirectory;
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ReportProvider"/> class.
	/// </summary>
	public ReportProvider(DirectoryInfo reportsDirectory)
	{
		_reportsDirectory = reportsDirectory;
	}
	
	/// <summary>
	/// Retrieves a report as a stream based on the specified report identifier.
	/// </summary>
	public Stream GetReport(string reportId)
	{
		var resourceFileInfo = _reportsDirectory
			.GetFiles(reportId, SearchOption.AllDirectories)
			.FirstOrDefault(f => f.Name == Path.GetFileName(reportId));
		return File.OpenRead(resourceFileInfo.FullName);
	}
	
	/// <summary>
	/// Retrieves the report descriptor for the specified report identifier.
	/// </summary>
	public ReportDescriptor GetReportDescriptor(string reportId)
	{
		var type = Path.GetExtension(reportId) == ".rdlx" ? ReportType.RdlXml : ReportType.RpxXml;
		return new ReportDescriptor(type);
	}
	
	/// <summary>
	/// Retrieves the list of available reports in the directory.
	/// </summary>
	public IEnumerable<string> GetReports()
	{
		string[] validExtensions = { ".rdl", ".rdlx", ".rdlx-master", ".rpx" };
		return GetFileStoreReports(validExtensions);
	}

	/// <summary>
	/// Retrieves report names from the directory based on valid file extensions.
	/// </summary>
	private string[] GetFileStoreReports(string[] validExtensions)
	{
		return _reportsDirectory
			.EnumerateFiles("*.*")
			.Select(x => x.Name)
			.Where(x => validExtensions.Any(x.EndsWith))
			.ToArray();
	}
}