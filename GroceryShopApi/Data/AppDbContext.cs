using Microsoft.EntityFrameworkCore;
using GroceryShopApi.Models;

namespace GroceryShopApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
