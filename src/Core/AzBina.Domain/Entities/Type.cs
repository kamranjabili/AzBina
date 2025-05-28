namespace AzBina.Domain.Entities;

public class Type : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int? DependOn { get; set; }

    public Type DependOnId { get; set; }
    public ICollection<Type> DependedTypes { get; set; }
    public ICollection<Ad> Ads { get; set; }



}
