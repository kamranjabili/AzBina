namespace AzBina.Domain.Entities;

public class User:BaseEntity
{
    public string Name { get; set; } = null!;
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Boolean isAgent { get; set; }
    public DateTime CreatedAt { get; set; }


    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Ad> Ads { get; set; }

}
