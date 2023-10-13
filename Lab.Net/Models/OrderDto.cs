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
        [RegularExpression(@"^.*\S.*$", ErrorMessage = "The field cannot be empty or contain only white spaces.")]
        public string Id { get; set; }
        [DataType(DataType.DateTime)]
        public string DeliveryTime { get; set; }
        [DataType(DataType.DateTime)]
        public string OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public double Price { get; set; }
        public List<BasketDishDto> Dishes { get; set; }
        [MinLength(1)]
        public string Address { get; set; }


    }
}
