using System.ComponentModel.DataAnnotations;

namespace TucStudent
{
    public class AgeValidatorAttribute : ValidationAttribute
    {
        public int MinimumAge { get; }

        public AgeValidatorAttribute(int minimumAge)
        {
            MinimumAge = minimumAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime birthDate)
            {
                var today = DateTime.Today;
                var age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;

                if (age < MinimumAge)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            else
            {
                return new ValidationResult("Invalid date format.");
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Student must be at least {MinimumAge} years old.";
        }
    }
}

