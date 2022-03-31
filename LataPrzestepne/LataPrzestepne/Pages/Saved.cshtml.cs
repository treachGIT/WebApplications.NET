using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace LataPrzestepne.Pages
{
    public class SavedModel : PageModel
    {
        public List<Birthday> birthdays { get; set; }
        public void OnGet()
        {
            birthdays = new List<Birthday>();

            var Data = HttpContext.Session.GetString("Data");

            if (Data != null)
                birthdays = JsonConvert.DeserializeObject<List<Birthday>>(Data);
        }
    }
}
