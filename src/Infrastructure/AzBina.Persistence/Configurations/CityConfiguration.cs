using AzBina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzBina.Persistence.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {

        builder.Property(c => c.Name)
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.HasMany(c => c.Districts)
        .WithOne(d => d.City)
        .HasForeignKey(d => d.CityId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Ads)
        .WithOne(a => a.City)
        .HasForeignKey(a => a.CityId)
        .OnDelete(DeleteBehavior.Restrict);

    }
}
