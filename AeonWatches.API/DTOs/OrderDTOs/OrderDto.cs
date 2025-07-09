using System.ComponentModel.DataAnnotations;

namespace AeonWatches.API.DTOs.OrderDTOs;

public class OrderDto
{
    [Required(ErrorMessage = "Customer detail is required.")]
    public CustomerDetailDto CustomerDetail { get; set; }
    [Required(ErrorMessage = "Items are required.")]
    public List<ItemDto> Items { get; set; }
}