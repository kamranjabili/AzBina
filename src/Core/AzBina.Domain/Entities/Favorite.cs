namespace AzBina.Domain.Entities;

public class Favorite:BaseEntity
{
    public Ad Ad { get; set; }
    public Guid AdId { get; set; }
}
