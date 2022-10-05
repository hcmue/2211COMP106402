using System.ComponentModel.DataAnnotations;

namespace DemoBuoi04.Models
{
    public class BirthDateCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var birthDate = (DateTime)value;
            if (DateTime.Now.Year - birthDate.Year < 18)
            {
                return new ValidationResult("Chưa đủ 18 tuổi");
            }
            return ValidationResult.Success;
        }
    }
}