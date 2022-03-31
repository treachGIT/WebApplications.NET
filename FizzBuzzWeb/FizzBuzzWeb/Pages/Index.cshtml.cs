using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

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
                //Alert = FizzBuzz.CheckNumber();
                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(FizzBuzz));
                return RedirectToPage("./SavedInSession");
            }

            Alert = String.Empty;
            return Page();
        }

    }
}