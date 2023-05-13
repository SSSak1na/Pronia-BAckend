using System;

var builder = WebApplication.CreateBuilder(args);

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
object value = builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"))); app.UseStaticFiles();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
