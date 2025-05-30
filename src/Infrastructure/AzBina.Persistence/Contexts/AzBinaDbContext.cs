using AzBina.Domain.Entities;
using AzBina.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AzBina.Persistence.Contexts;

public class AzBinaDbContext:DbContext
{
    public AzBinaDbContext(DbContextOptions<AzBinaDbContext> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Bio> Bios { get; set; }
    public DbSet<Ad> Ads { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Town> Towns { get; set; }
    public DbSet<Domain.Entities.Type> Types { get; set; }
}
