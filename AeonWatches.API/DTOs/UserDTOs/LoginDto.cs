using System.ComponentModel.DataAnnotations;

namespace AeonWatches.API.DTOs.UserDTOs;

public class LoginDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}