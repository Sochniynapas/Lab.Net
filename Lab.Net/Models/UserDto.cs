using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public enum Gender
    {
        Male, 
        Female
    }
    public class UserDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MinLength(1)]
        public string FullName { get; set; }
        [DataType(DataType.DateTime)]
        public string BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public Guid Address { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(1)]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
