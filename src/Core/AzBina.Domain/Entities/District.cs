namespace AzBina.Domain.Entities;

public class District:BaseEntity
{
    public string Name { get; set; } = null!;
    public City City { get; set; } = null!;
    public Guid CityId { get; set; }
    public ICollection<Town> Towns { get; set; }
    public ICollection<Ad> Ads { get; set; }
}
