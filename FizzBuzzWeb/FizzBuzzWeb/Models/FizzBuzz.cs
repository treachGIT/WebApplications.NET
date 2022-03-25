using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość pomiędzy 1 a 1000")]
        public int? Number { get; set; }
    }

}
