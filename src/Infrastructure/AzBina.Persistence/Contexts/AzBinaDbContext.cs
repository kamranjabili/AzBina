using AzBina.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzBina.Persistence.Contexts;

public class AzBinaDbContext:DbContext
{
    public AzBinaDbContext(DbContextOptions<AzBinaDbContext> options):base(options)
    {
    }

    public DbSet<Bio> Bios { get; set; }
}
