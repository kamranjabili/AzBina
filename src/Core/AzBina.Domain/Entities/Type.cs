namespace AzBina.Domain.Entities;

public class Type : BaseEntity
{
    public string Name { get; set; } = null!;

    public Guid ParentTypeId { get; set; }

    // Self-reference navigation property
    public Type? ParentType { get; set; }

    // Self-reference collection (inverse)
    public ICollection<Type> SubTypes { get; set; } = new List<Type>();
}

