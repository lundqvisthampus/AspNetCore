using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<UserService>();

builder.Services.AddAuthentication("AuthCookie").AddCookie("AuthCookie", x =>
{
    x.LoginPath = "/signin";
    x.ExpireTimeSpan = TimeSpan.FromMinutes(60);
});

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); // "Vem du är"
app.UseAuthorization(); // "Vad du får göra"

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
