using System.ComponentModel.DataAnnotations;

namespace Lab.Net.Models
{
    public class TokenResponse
    {
        [Required]
        public string Token { get; set; } 

    }
}
