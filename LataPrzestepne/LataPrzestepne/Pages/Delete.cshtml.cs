#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LataPrzestepne.Data;
using LataPrzestepne.Models;

namespace LataPrzestepne.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly LataPrzestepne.Data.BirthdayContext _context;

        public DeleteModel(LataPrzestepne.Data.BirthdayContext context)
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
