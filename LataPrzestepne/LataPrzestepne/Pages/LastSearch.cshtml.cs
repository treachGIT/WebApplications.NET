using LataPrzestepne.Data;
using LataPrzestepne.Dto;
using LataPrzestepne.Models;
using LataPrzestepne.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LataPrzestepne.Pages
{
    public class LastSearchModel : PageModel
    {
        private readonly IBirthdayService _birthdayService;

        public LastSearchModel(IBirthdayService birthdayService)
        {
            _birthdayService = birthdayService;
        }

        public IList<BirthdayDto> Birthdays { get; set; }

        public void OnGet()
        {
            Birthdays = _birthdayService.GetAllEntries();
        }

    }
}
