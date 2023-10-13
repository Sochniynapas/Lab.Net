using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class UserEditModel
    {
        [Required]
        [MinLength(1)]
        public string FullName { get; set; }
        [DataType(DataType.DateTime)]
        public string BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public Guid Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
