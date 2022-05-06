using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LataPrzestepneIdentity.Models
{
    public class Birthday
    {
        public int Id { get; set; }

        [Display(Name = "Rok urodzenia")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość pomiędzy 1899 a 2022")]
        public int Year { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [MaxLength(100, ErrorMessage = "Maksymalna długość imienia to 100 liter")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [MaxLength(100, ErrorMessage = "Maksymalna długość nazwiska to 100 liter")]
        public string Surname { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }

        public Birthday()
        {
            CreatedDate = DateTime.Now;
        }

        public string GetMessage()
        {
            string message = string.Empty;

            message = $"{Name} urodził się w {Year} roku. ";

            if (isLeapYear())
            {
                message += "To był rok przestępny.";
            }
            else
            {
                message += "To nie był rok przestępny.";
            }

            return message;
        }

        public string GetMessageForHistory()
        {
            string message = string.Empty;
            message = $"{Name},{Year}";

            if (isLeapYear())
            {
                message += " - rok przestępny";
            }

            return message;
        }


        private bool isLeapYear()
        {
            if (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0)
            {
                return true;
            }
            return false;
        }
    }
}
