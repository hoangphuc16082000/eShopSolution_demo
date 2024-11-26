using Microsoft.EntityFrameworkCore;
using eShopSolution.Data.EF;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext sử dụng PostgreSQL với chuỗi kết nối từ appsettings.json
builder.Services.AddDbContext<EShopDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // Đảm bảo chuỗi kết nối trùng khớp

// Cấu hình Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Cấu hình HTTP request pipeline cho Swagger trong môi trường phát triển
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
