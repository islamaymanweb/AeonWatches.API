﻿using AeonWatches.API.Entities.OrderEntities;

namespace AeonWatches.API.Entities.UserEntities;

public class AppUser
{
    public int Id { get; set; }
  
    public required string UserName { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
    public Gender Gender { get; set; }
    public List<CustomerDetail> CustomerDetails  { get; set; } = new();
}