using Microsoft.EntityFrameworkCore;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();
}
