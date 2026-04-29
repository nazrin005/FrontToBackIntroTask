using FrontToBackIntroTask.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{Id?}");

app.Run();
