using System.ComponentModel.DataAnnotations;

namespace LataPrzestepne.Models
{
    public class Birthday
    {
        [Display(Name = "Rok urodzenia")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość pomiędzy 1899 a 2022")]
        public int? Year { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [MaxLength(100, ErrorMessage = "Maksymalna długość imienia to 100 liter")]
        public string? Name { get; set; }

        public string? SavedMessage { get; set; }

        public string GetMessage()
        {
            string message = string.Empty;

            message = $"{Name} urodził się w {Year} roku. ";
            SavedMessage = $"{Name},{Year}";

            if (isLeapYear())
            {
                message += "To był rok przestępny.";
                SavedMessage += " - rok przestępny";
            }
            else
            {
                message += "To nie był rok przestępny.";
            }

            return message;
        }

        private bool isLeapYear()
        {         
            if (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0 )
            {
                return true;
            }       
            return false;
        }
    }
}
