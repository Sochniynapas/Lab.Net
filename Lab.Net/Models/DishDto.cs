using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class DishDto

    {
        [Required(ErrorMessage = "The field is required.")]
        [RegularExpression(@"^.*\S.*$", ErrorMessage = "The field cannot be empty or contain only white spaces.")]
        public int Id { get; set; }

        [MinLength(1)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public string Image { get; set; }
        [Required]
        public bool Vegetarian { get; set; }
        public double Rating { get; set; }  
        public enum Category
        {
            Wok,
            Pizza,
            Soup,
            Dessert,
            Drink
        }

    }
}
