namespace AzBina.Domain.Entities;

public class Bios:BaseEntity
{
    public Guid Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
}
