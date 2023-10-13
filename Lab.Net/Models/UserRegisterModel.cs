using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class UserRegisterModel
    {
        [Required]
        [MinLength(1)]
        public string FullName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(1)]
        public string Email { get; set; }
        public Guid Address { get; set; }
        [DataType(DataType.DateTime)]
        public string BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
