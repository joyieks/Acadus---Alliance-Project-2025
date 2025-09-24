using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acadus___Alliance_Project_2025.Pages.Auth
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                ModelState.AddModelError(string.Empty, "Email and Password are required.");
                return Page();
            }

            var normalizedEmail = Email.Trim().ToLowerInvariant();
            var password = Password;

            // Hardcoded users → simple role routing
            if (normalizedEmail == "student@gmail.com" && password == "student123")
            {
                return RedirectToPage("/Student/Index");
            }
            if (normalizedEmail == "teacher@gmail.com" && password == "teacher123")
            {
                return RedirectToPage("/Teacher/Index");
            }
            if (normalizedEmail == "admin@gmail.com" && password == "admin123")
            {
                return RedirectToPage("/Admin/Index");
            }

            ModelState.AddModelError(string.Empty, "Invalid email or password.");
            return Page();
        }
    }
}

