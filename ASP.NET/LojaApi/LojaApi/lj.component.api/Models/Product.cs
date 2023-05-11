﻿namespace lj.component.api.Models;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Decription { get; set; }
    public long Stock { get; set; }
    public string ImageURL { get; set; }
    public Category Category { get; set; }
    public int IdCategory { get; set; }
}
