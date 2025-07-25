using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using GrapeCity.ActiveReports.Web.Designer;

string resourcesDirectoryName = "resources";

DirectoryInfo ResourcesRootDirectory =
    new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), resourcesDirectoryName + Path.DirectorySeparatorChar));

var options = new WebApplicationOptions
{
	Args = args,
	ContentRootPath = AppContext.BaseDirectory,
	WebRootPath = resourcesDirectoryName
};

var builder = WebApplication.CreateBuilder(options);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services
        .AddReportViewer()
        .AddReportDesigner()
        .AddMvc(options => options.EnableEndpointRouting = false)
        .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);


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

app.UseRouting();

app.UseReportDesigner(config => config.UseFileStore(ResourcesRootDirectory, null, FileStoreOptions.NestedFoldersLookup));
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
