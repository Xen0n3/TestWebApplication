using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TestApplication.Models;
using TestApplication.Services;
var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(option => option.UseNpgsql(connection));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IWarehouseService, WarehouseService>();
builder.Services.AddTransient<IProductsService, ProductsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Warehouses}/{id?}");

app.Run();

