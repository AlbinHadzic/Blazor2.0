using System.ComponentModel.DataAnnotations;

namespace TucStudent
{
    public class StudentsApply
    {
        public int id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZåäöÅÄÖ]*$", ErrorMessage = "Special characters or numbers are not accepted.")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZåäöÅÄÖ]*$", ErrorMessage = "Special characters or numbers are not accepted.")]
        public string lastName { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }
        [Required, DataType(DataType.Date),AgeValidator(10)]
        public DateTime birthDate { get; set; }
    }
}
