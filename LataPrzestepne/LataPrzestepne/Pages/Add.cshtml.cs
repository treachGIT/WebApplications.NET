using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using LataPrzestepne.Data;
using LataPrzestepne.Services;

namespace LataPrzestepne.Pages
{
    public class AddModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBirthdayService _birthdayService;

        [BindProperty]
        public Birthday Birthday { get; set; }

        public string Alert { get; set; }

        public AddModel(ILogger<IndexModel> logger, IBirthdayService birthdayService)
        {
            _logger = logger;
            _birthdayService = birthdayService;
        }

        public void OnGet()
        {
            Alert = String.Empty;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Alert = Birthday.GetMessage();
                _birthdayService.AddEntry(Birthday);
                return Page();
            }

            Alert = String.Empty;
            return Page();
        }

    }
}