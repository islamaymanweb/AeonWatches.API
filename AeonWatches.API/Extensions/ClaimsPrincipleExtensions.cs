﻿using System.Security.Claims;

namespace AeonWatches.API.Extensions;

public static class ClaimsPrincipleExtensions 
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirst(ClaimTypes.Name)?.Value;
        
        return string.IsNullOrEmpty(username) ? null : username;
    }
    
    public static int GetUserId(this ClaimsPrincipal user)
    {
        var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        return string.IsNullOrEmpty(userIdClaim) ? -1 : int.Parse(userIdClaim);
    }
}