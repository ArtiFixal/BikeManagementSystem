using BikeManagementSystemLib;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<VendorService>();
builder.Services.AddScoped<BikeTypeService>();
builder.Services.AddScoped<ImageServiceExtended>();
builder.Services.AddScoped<BikeService>();
builder.Services.AddScoped<RentalService>();
builder.Services.AddScoped<ClientService>();
builder.Services.AddScoped<MaintenanceService>();

builder.Services.AddDbContext<BikeManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
