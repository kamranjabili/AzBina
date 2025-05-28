namespace AzBina.Domain.Entities;

public class Category:BaseEntity
{
    public string Name { get; set; }
    public ICollection<Ad> Ads { get; set; }
}
