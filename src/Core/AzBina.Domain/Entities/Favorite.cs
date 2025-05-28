namespace AzBina.Domain.Entities;

public class Favorite:BaseEntity
{
    public User User { get; set; }
    public Guid UserId { get; set; }

    public Ad Ad { get; set; }
    public Guid AdId { get; set; }
}
