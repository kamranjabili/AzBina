namespace AzBina.Domain.Entities;

public class Image:BaseEntity
{
    public string Image_Url { get; set; }
    public bool is_main { get; set; }

    public Ad Ad { get; set; }
    public Guid AdId { get; set; }
}
