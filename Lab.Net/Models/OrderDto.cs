using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public enum OrderStatus
    {
        InProcess, 
        Delivered
    }
    public class OrderDto
    {
        [Required(ErrorMessage = "The field is required.")]
        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string DeliveryTime { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string OrderTime { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public List<BasketDishDto> Dishes { get; set; }
        [Required]
        [MinLength(1)]
        public string Address { get; set; }


    }
}
