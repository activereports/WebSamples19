using BlazorViewer_CustomStore.Data;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;

var resourcesRootDirectory =
    new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "resources" + Path.DirectorySeparatorChar));

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton(new ReportProvider(resourcesRootDirectory));
builder.Services.AddSingleton(new DataService());
builder.Services.AddSingleton<ReportResourceProvider>();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}

var reportProvider = app.Services.GetRequiredService<ReportProvider>();
var reportResourceProvider = app.Services.GetRequiredService<ReportResourceProvider>();
var dataService = app.Services.GetRequiredService<DataService>();

app.UseReportViewer(settings =>
{
    settings.UseReportProvider(reportProvider);
    settings.UseResourceProvider(reportResourceProvider);
    
    //it should be used only for RDLX reports
    settings.LocateDataSource += sourceArgs =>
    {
        return sourceArgs.Report.Name switch
        {
            "AcmeStore.rdlx" => dataService.GetData("AcmeStore.csv"),
            "Invoice.rdlx" => dataService.GetData("Invoice.csv"),
            _ => null
        };
    };
});

app.UseRouting();
app.UseStaticFiles();

app.MapFallbackToPage("/_Host");
app.MapBlazorHub();

app.Run();