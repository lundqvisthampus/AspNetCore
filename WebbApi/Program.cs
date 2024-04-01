using Infrastructures.Contexts;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebbApi.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.RegisterJwt(builder.Configuration);
builder.Services.AddHttpClient();
builder.Services.AddScoped<SubscribeManager>();
builder.Services.AddScoped<CourseManager>();
builder.Services.AddScoped<ContactManager>();
builder.Services.RegisterSwagger();
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
});
builder.Services.AddDefaultIdentity<ApplicationUser>(x =>
{
    x.User.RequireUniqueEmail = true;
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

app.UseSwagger();
app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "Silicon"));
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
