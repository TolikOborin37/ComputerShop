using ComputerShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//подключение к бд, строка подключения находится в appsettings.json
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ProductsContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Products}/{Action=Index}");


app.Run();
