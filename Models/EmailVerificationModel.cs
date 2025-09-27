using System.ComponentModel.DataAnnotations;

namespace Acadus___Alliance_Project_2025.Models
{
    public class EmailVerificationModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}

