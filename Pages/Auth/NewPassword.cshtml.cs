using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acadus___Alliance_Project_2025.Pages.Auth
{
    public class NewPasswordModel : PageModel
    {
        [BindProperty]
        public string NewPassword { get; set; } = string.Empty;

        [BindProperty]
        public string ConfirmPassword { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(NewPassword) || string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                ModelState.AddModelError(string.Empty, "Both fields are required.");
                return Page();
            }

            if (!string.Equals(NewPassword, ConfirmPassword))
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match.");
                return Page();
            }

            return RedirectToPage("/Auth/PasswordResetSuccess");
        }
    }
}

