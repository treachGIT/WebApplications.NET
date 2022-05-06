using LataPrzestepneIdentity.Dto;
using LataPrzestepneIdentity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LataPrzestepneIdentity.Pages
{
    [Authorize]
    public class LastSearchModel : PageModel
    {
        private readonly IBirthdayService _birthdayService;

        private readonly UserManager<IdentityUser> _userManager;

        public LastSearchModel(IBirthdayService birthdayService, UserManager<IdentityUser> userManager)
        {
            _birthdayService = birthdayService;
            _userManager = userManager;
        }

        public IList<BirthdayDto> Birthdays { get; set; }

        public string UserId;


        public void OnGet()
        {
            UserId = _userManager.GetUserId(User);

            Birthdays = _birthdayService.GetAllEntries(); 
        }

    }
}
