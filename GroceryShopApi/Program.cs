using Microsoft.EntityFrameworkCore;
using GroceryShopApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("GroceryDb"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAngular");
app.MapControllers();

app.Run();
