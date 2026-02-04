using System;
using System.ComponentModel.DataAnnotations;

namespace Entishar.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be 3-50 characters")]
        public string Username { get; set; } = string.Empty;


        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be 3-50 characters")]
        public string Password { get; set; } = string.Empty;  // zy ma eltask by2ol


        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Username must be 3-50 characters")]
        public string UserFullName { get; set; } = string.Empty;


        public bool IsActive { get; set; } = true;


        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(User), nameof(ValidateDOB))]
        public DateTime DateOfBirth { get; set; }


        public DateTime CreationDate { get; set; } = DateTime.Now;

        public static ValidationResult ValidateDOB(DateTime dob, ValidationContext context)
        {
            if (dob > DateTime.Now)
                return new ValidationResult("Date of Birth cannot be in the future");

            if (dob < DateTime.Now.AddYears(-150))
                return new ValidationResult("Date of Birth seems too old");

            return ValidationResult.Success;
        }
    }
}
