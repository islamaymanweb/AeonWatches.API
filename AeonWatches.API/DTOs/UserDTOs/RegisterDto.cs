using System.ComponentModel.DataAnnotations;

namespace AeonWatches.API.DTOs.UserDTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public int Gender { get; set; }
}