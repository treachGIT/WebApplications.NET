using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość pomiędzy 1 a 1000")]
        public int? Number { get; set; }

        public string CheckNumber()
        {
            string message = String.Empty;

            if (Number % 3 == 0)
            {
                if (Number % 5 == 0)
                {
                    message = "FizzBuzz";
                }
                else
                {
                    message = "Fizz";
                }
            }
            else if (Number % 5 == 0)
            {
                message = "Buzz";
            }
            else
            {
                message = "Liczba: " + Number.ToString() + " nie spełnia kryteriów FizzBuzz";
            }

            return message;
        }
    }

}
