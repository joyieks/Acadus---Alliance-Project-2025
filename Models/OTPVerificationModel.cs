using System.ComponentModel.DataAnnotations;

namespace Acadus___Alliance_Project_2025.Models
{
    public class OTPVerificationModel
    {
        [Required]
        [StringLength(1)]
        public string Otp1 { get; set; } = string.Empty;

        [Required]
        [StringLength(1)]
        public string Otp2 { get; set; } = string.Empty;

        [Required]
        [StringLength(1)]
        public string Otp3 { get; set; } = string.Empty;

        [Required]
        [StringLength(1)]
        public string Otp4 { get; set; } = string.Empty;
    }
}

