﻿namespace AeonWatches.API.DTOs.WatchDTOs;

public class WatchCardDto
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Reference { get; set; }
    public string PhotoUrl { get; set; }
    public decimal Price { get; set; }
    public string Stock { get; set; }
}