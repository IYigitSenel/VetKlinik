using Microsoft.EntityFrameworkCore;
using VetKlinik.Web.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<KlinikDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Varsayilan") ?? "Data Source=vetklinik.db"));

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    
app.Run();                              