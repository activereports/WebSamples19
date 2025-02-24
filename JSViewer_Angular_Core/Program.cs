using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using System.Reflection;

string resourcesDirectoryName = "Reports";
DirectoryInfo ReportsDirectory =

	new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? String.Empty, resourcesDirectoryName));

var options = new WebApplicationOptions
{
	Args = args,
	ContentRootPath = AppContext.BaseDirectory,
	WebRootPath = resourcesDirectoryName
};

var builder = WebApplication.CreateBuilder(options);

// Add services to the container.
builder.Services.AddReportViewer()
                .AddControllersWithViews();


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

app.UseReportViewer(settings =>
{
    settings.UseFileStore(ReportsDirectory);
});
app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();