﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace AeonWatches.API.Entities.OrderEntities;

[ExcludeFromCodeCoverage]
public class Item
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    [JsonIgnore]
    public int ItemTypeId { get; set; }
    public ItemType ItemType { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    [JsonIgnore]
    public int OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }
}