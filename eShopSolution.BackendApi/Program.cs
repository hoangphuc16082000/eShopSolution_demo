using eShopSolution.Application.Catalog.Products;
using eShopSolution.Application.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký DbContext
builder.Services.AddDbContext<EShopDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cấu hình CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
        policy.WithOrigins("http://localhost:4200")  // Địa chỉ ứng dụng Angular
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Đăng ký dịch vụ
builder.Services.AddTransient<IStorageService, FileStorageService>();

builder.Services.AddTransient<IPublicProductService, PublicProductService>();
builder.Services.AddTransient<IManageProductService, ManageProductService>();

// Thêm các dịch vụ MVC
builder.Services.AddControllersWithViews();

// Thêm Swagger vào container
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Swagger eShop Solution", 
        Version = "v1" 
    });
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Áp dụng CORS trước các middleware khác
app.UseCors("AllowSpecificOrigins");

// Cấu hình Swagger (middleware)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger eShop Solution v1");
        c.RoutePrefix = string.Empty; // Truy cập tại đường dẫn root "/"
    });
}

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
