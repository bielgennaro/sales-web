﻿namespace SalesWeb.Models;

public class Department
{
    public Department()
    {
    }

    public Department(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

    public void AddSeller(Seller seller)
    {
        Sellers.Add(seller);
    }

    public void TotalSales(DateTime initial, DateTime final)
    {
        Sellers.Sum(seller => seller.TotalSales(initial, final));
    }
}