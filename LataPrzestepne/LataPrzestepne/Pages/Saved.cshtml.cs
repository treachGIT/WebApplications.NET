using LataPrzestepne.Data;
using LataPrzestepne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace LataPrzestepne.Pages
{
    public class SavedModel : PageModel
    {
        public List<Birthday> Birthdays { get; set; }
        public void OnGet()
        {
            Birthdays = new List<Birthday>();

            var Data = HttpContext.Session.GetString("Data");

            if (Data != null)
                Birthdays = JsonConvert.DeserializeObject<List<Birthday>>(Data);
        }
    }
    
}
