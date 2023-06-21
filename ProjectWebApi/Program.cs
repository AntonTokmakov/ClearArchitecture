using Microsoft.Extensions.Configuration;
using Tasks.Controllers.Repositories;
using Tasks.Models;
using TrialProject.UseCase;
using Microsoft.EntityFrameworkCore;
using ProjectApplication.Interface;
using ProjectApplication;
using TrialProject.Models;
using TrialProject.Controllers.Repositories;

var builder = WebApplication.CreateBuilder(args);


var _configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProjectContext>(options =>
    options.UseNpgsql(_configuration.GetConnectionString("ConnectionDB")));
builder.Services.AddScoped<IRepository<Project>, SQLProjectRepository>();
//builder.Services.AddScoped<ITechnicalSpecificationServices, TechnicalSpecificationService>();
builder.Services.AddScoped<IRepository<TechnicalSpecification>, SQLTechnicalSpecification>();
builder.Services.AddScoped<ITechnicalSpecificationServices, TechnicalSpecificationService>();
builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
