namespace AzBina.Domain.Entities;

public class Image:BaseEntity
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public Boolean IsMain { get; set; }
    public Ad Ad { get; set; }
    public Guid AdId { get; set; }

}
