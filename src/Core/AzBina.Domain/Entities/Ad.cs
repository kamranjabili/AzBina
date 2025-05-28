namespace AzBina.Domain.Entities;

public class Ad:BaseEntity
{
    public Guid Id { get; set; }
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }
    public int RoomCount { get; set; }
    public bool ForSale { get; set; }
    public decimal Price { get; set; }
    public decimal Field { get; set; }

    public decimal HouseField { get; set; }
    public int Floor { get; set; }
    public City City { get; set; }
    public Guid CityId { get; set; }
    public Town Town { get; set; }
    public Guid TownId { get; set; }
    public District District { get; set; }
    public Guid DistrictId { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; }
    public Type Type { get; set; }
    public Guid TypeId { get; set; }

    public Boolean Deed { get; set; }
    public string Map { get; set; }
    public string Address { get; set; }
    public Boolean IsActivated { get; set; }
    public Boolean IsApproved { get; set; }
    public int BuildingFloor { get; set; }
    public Boolean IsRepaired { get; set; }
    public int BuildingType { get; set; }

    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Image> Images { get; set; }


}
