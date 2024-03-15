using Infrastructures.Contexts;
using Infrastructures.Helpers.Middlewares;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddDefaultIdentity<ApplicationUser>(x =>
{
    x.User.RequireUniqueEmail = true;
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/signin";
    x.LogoutPath = "/signout";

    x.Cookie.HttpOnly = true;
    x.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    x.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    x.SlidingExpiration = true;
    x.Cookie.IsEssential = true;
});

builder.Services.AddScoped<AddressManager>();

builder.Services.AddAuthentication().AddFacebook(x =>
{
    x.AppId = "386619490798238";
    x.AppSecret = "adf4c1985472e7e4a7b472f097a4a93a";
    x.Fields.Add("first_name");
    x.Fields.Add("last_name");
});

builder.Services.AddAuthentication().AddGoogle(x =>
{
    x.ClientId = "328592272425-g1uq2rhnumd746hcnn5svnd5ocmbrr21.apps.googleusercontent.com";
    x.ClientSecret = "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";
});

var app = builder.Build();
app.UseHsts();
app.UseStatusCodePagesWithReExecute("/error", "?statusCode={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UserSessionValidation();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();