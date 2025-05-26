namespace AzBina.Domain.Entities;

public class City:BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<District> Districts { get; set; }
}
