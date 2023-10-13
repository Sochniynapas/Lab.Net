using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class LoginCredentials
    {

        [EmailAddress]
        [MinLength(1)]
        public string Email { get; set; }
        [MinLength(1)]
        public string Password { get; set; }

    }
}
