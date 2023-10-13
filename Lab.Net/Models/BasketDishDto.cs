using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class BasketDishDto
    {
        [Required(ErrorMessage = "The field is required.")]
        [RegularExpression(@"^.*\S.*$", ErrorMessage = "The field cannot be empty or contain only white spaces.")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public int Amount { get; set; }
        public string Image { get; set;}
    }
}
