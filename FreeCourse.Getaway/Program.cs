using Microsoft.AspNetCore.Authentication.JwtBearer;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", options =>
{
    options.Authority = builder.Configuration["IdentityServerURL"];
    options.Audience = "resource_gateway";
    options.RequireHttpsMetadata = false;
});
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    //ocelot yapýlanmasý
    config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
    .AddJsonFile($"configuration.{hostingContext.HostingEnvironment.EnvironmentName.ToLower()}.json")
    .AddEnvironmentVariables();
});

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"configuration.{builder.Environment.EnvironmentName}.json", true, true)
                            .Build();

builder.Services.AddOcelot(configuration);

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.UseOcelot().Wait();
app.Run();
