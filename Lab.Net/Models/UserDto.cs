using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lab.Net.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Male, 
        Female
    }
    public class UserDto 
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [MinLength(1)]
        public string FullName { get; set; }
        [DataType(DataType.DateTime)]
        public string? BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public Guid? Address { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(1)]
        public string Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
