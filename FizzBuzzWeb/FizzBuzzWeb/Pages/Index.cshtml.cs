using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public string Alert { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Alert = String.Empty;

            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }

        public IActionResult OnPost()
        {
            Alert = String.Empty;

            if (!ModelState.IsValid)
            {
                CheckNumber();
                return Page();
            }

            return Page();
        }

        public void CheckNumber()
        {
            if (FizzBuzz.Number % 3 == 0)
            {
                if (FizzBuzz.Number % 5 == 0)
                {
                    Alert = "FizzBuzz";
                }
                else
                {
                    Alert = "Fizz";
                }
            }
            else if (FizzBuzz.Number % 5 == 0)
            {
                Alert = "Buzz";
            }
            else
            {           
                Alert = "Liczba: " + FizzBuzz.Number.ToString() + " nie spełnia kryteriów FizzBuzz";
            }
        }
    }
}