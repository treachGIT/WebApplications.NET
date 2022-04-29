using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using LataPrzestepne.Data;
using LataPrzestepne.Services;
using LataPrzestepne.Dto;

namespace LataPrzestepne.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBirthdayService _birthdayService;
        public IList<BirthdayDto> Birthdays { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBirthdayService birthdayService)
        {
            _logger = logger;
            _birthdayService = birthdayService;
        } 

        public void OnGet()
        {
            Birthdays = _birthdayService.GetEntriesFromToday();
        }

    }
}