using System.ComponentModel.DataAnnotations;

namespace DemoBuoi04.Models
{
    internal class CheckOverDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var birthDate = (DateTime)value;
            return DateTime.Now.Year - birthDate.Year <= 60;
        }
    }
}