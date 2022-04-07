using LataPrzestepne.Data;
using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LataPrzestepne.Pages
{
    public class LastSearchModel : PageModel
    {
        private readonly BirthdayContext _context;

        public LastSearchModel(BirthdayContext context)
        {
            _context = context;
        }

        public IList<Birthday> Birthdays { get; set; }

        public async Task OnGetAsync()
        {
            Birthdays = await _context.Birthdays.OrderByDescending(x => x.CreatedDate).Take(20).ToListAsync();
        }

    }
}
