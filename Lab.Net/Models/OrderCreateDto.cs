using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class OrderCreateDto
    {
        [DataType(DataType.DateTime)]
        public string DeliveryTime { get; set; }

        
        [Required(ErrorMessage = "The field is required.")]
        [RegularExpression(@"^.*\S.*$", ErrorMessage = "The field cannot be empty or contain only white spaces.")]
        public string AddressId { get; set; }


    }
}
