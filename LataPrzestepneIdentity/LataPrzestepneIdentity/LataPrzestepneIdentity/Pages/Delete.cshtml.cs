using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LataPrzestepneIdentity.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly LataPrzestepneIdentity.Data.ApplicationDbContext _context;

        public DeleteModel(LataPrzestepneIdentity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var birthday = await _context.Birthdays.FindAsync(id);

            if (birthday != null)
            {
                _context.Birthdays.Remove(birthday);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./LastSearch");
        }

    }
}
