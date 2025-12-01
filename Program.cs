using Microsoft.EntityFrameworkCore;
using InfoCut.Models;
using InfoCut.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Defaultconnection");
    options.UseSqlServer(connectionString);
});

builder.Services.AddSession();
var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
     name: "default",
    pattern: "{controller=Home}/{action=Signup}/{id?}"
);
app.UseStaticFiles();

app.UseAuthentication();
app.UseSession();


app.Run();
