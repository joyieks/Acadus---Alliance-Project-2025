using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acadus___Alliance_Project_2025.Pages.Auth
{
    public class EmailVerificationModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                ModelState.AddModelError(nameof(Email), "Email is required.");
                return Page();
            }

            // Navigate to OTP step (stub)
            return RedirectToPage("/Auth/OTPVerification");
        }
    }
}

