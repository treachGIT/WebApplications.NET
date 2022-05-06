using Microsoft.AspNetCore.Identity;

namespace LataPrzestepneIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Birthday>? Birthdays { get; set; }
    }
}
