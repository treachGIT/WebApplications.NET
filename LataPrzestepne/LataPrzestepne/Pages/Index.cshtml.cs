using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace LataPrzestepne.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Birthday Birthday { get; set; }

        public string Alert { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
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
                SaveToSession(Birthday);
                return Page();
            }

            Alert = String.Empty;
            return Page();
        }

        public void SaveToSession(Birthday newItem)
        {
            List<Birthday> birthdays = new List<Birthday>();

            var Data = HttpContext.Session.GetString("Data");

            if (Data != null)
                birthdays = JsonConvert.DeserializeObject<List<Birthday>>(Data);

            birthdays.Add(newItem);
            HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(birthdays, Formatting.Indented));
        }
    }
}