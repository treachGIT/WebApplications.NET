using LataPrzestepneIdentity.Models;
using LataPrzestepneIdentity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LataPrzestepneIdentity.Pages
{
    [Authorize]
    public class AddModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBirthdayService _birthdayService;

        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public Birthday Birthday { get; set; }

        public string Alert { get; set; }

        public AddModel(ILogger<IndexModel> logger, IBirthdayService birthdayService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _birthdayService = birthdayService;
            _userManager = userManager;
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
                Birthday.UserId = _userManager.GetUserId(User);
                _birthdayService.AddEntry(Birthday);
                return Page();
            }

            Alert = String.Empty;
            return Page();
        }

    }
}
