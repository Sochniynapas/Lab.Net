﻿using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class DishDto

    {
        [Required(ErrorMessage = "The field is required.")]

        public Guid Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        public string Description { get; set; }
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
