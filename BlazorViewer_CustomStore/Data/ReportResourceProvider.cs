using System.Text;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Web.Viewer;

namespace BlazorViewer_CustomStore.Data;

/// <summary>
/// Represents a provider that retrieves report resources based on the specified resource information.
/// </summary>
public class ReportResourceProvider: IReportResourceProvider
{
	private readonly DataService _dataService;
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ReportResourceProvider"/> class.
	/// </summary>
	public ReportResourceProvider(DataService dataService)
	{
		_dataService = dataService;
	}
	
	/// <summary>
	/// Retrieves the specified report resource.
	/// </summary>
	public Stream GetResource(ResourceInfo resource)
	{
		if (resource.Type == ResourceType.DataFile)
		{
			//the data for the report can be obtained from different places, db, files, or compute in memory.
			//it can be used for RDLX and Section reports.
			var data = _dataService.GetData(resource.Name);
			var byteArray = Encoding.UTF8.GetBytes(data);
			return new MemoryStream(byteArray);
		}
		
		//Implement other resource types support if needed
		
		return null;
	}
}