using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Net.Models
{


    
    public class OrderInfoDto
    {
        [Required(ErrorMessage = "The field is required.")]
        public Guid Id { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public string DeliveryTime { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string OrderTime { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public double Price { get; set; }

        
    }
}
