using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CapstoneProjectFashionHub.Models;
using CapstoneProjectFashionHub.Data;

namespace CapstoneProjectFashionHub.Pages
{
    public class ContactModel : PageModel
    {
        private readonly AplikasiDbContext _context;

        public ContactModel(AplikasiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactForm ContactForm { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactForm.Add(ContactForm);
            await _context.SaveChangesAsync();

            TempData["alertMessage"] = "Pesan berhasil terkirim!";
            return RedirectToPage("Contact");
        }

    }
}
