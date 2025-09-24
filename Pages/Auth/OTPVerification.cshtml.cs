using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acadus___Alliance_Project_2025.Pages.Auth
{
    public class OTPVerificationModel : PageModel
    {
        [BindProperty]
        public string Otp1 { get; set; } = string.Empty;
        [BindProperty]
        public string Otp2 { get; set; } = string.Empty;
        [BindProperty]
        public string Otp3 { get; set; } = string.Empty;
        [BindProperty]
        public string Otp4 { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var code = string.Concat(Otp1, Otp2, Otp3, Otp4);
            if (code.Length != 4)
            {
                ModelState.AddModelError(string.Empty, "Please enter the 4-digit code.");
                return Page();
            }

            // Stub: proceed to new password step
            return RedirectToPage("/Auth/NewPassword");
        }
    }
}

