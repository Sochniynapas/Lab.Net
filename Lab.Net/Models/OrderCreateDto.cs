using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class OrderCreateDto
    {
        [Required]
        [DataType(DataType.DateTime)]
        public string DeliveryTime { get; set; }

        
        [Required(ErrorMessage = "The field is required.")]
        public Guid AddressId { get; set; }


    }
}
