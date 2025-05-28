namespace AzBina.Domain.Entities;

public class User:BaseEntity
{
    public string Name { get; set; }
    public string Phone_Number { get; set; }
    public string Email { get; set; }
    public bool is_agent { get; set; }

    public ICollection<Ad> Ads { get; set; }
    public ICollection<Favorite> Favorites { get; set; }
}
