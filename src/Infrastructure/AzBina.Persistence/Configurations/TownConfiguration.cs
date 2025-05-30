using AzBina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzBina.Persistence.Configurations;

public class TownConfiguration : IEntityTypeConfiguration<Town>
{
    public void Configure(EntityTypeBuilder<Town> builder)
    {
        builder.Property(t => t.Name)
          .IsRequired();

        builder.HasIndex(t => t.Name)
          .IsUnique();

        builder.HasMany(t => t.Ads)
        .WithOne(t => t.Town)
        .HasForeignKey(a => a.TownId)
        .OnDelete(DeleteBehavior.Restrict);
    }
}
