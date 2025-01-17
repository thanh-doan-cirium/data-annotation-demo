using System.ComponentModel.DataAnnotations;
using DataValidation.Validations;

namespace DataValidation.Models;

public class Employee
{
    [Display(Name = "First Name")]
    [Required, MinLength(3), MaxLength(30)]
    public string? FirstName { get; init; }

    [Required, MinLength(3), MaxLength(50)]
    public string? Surname { get; init; }

    [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
    public int Age { get; set; }

    [EmailAddress]
    public string? Email { get; init; }

    [RegularExpression("^[A-Z]{1,2}[0-9R][0-9A-Z]? [0-9][ABD-HJLNP-UW-Z]{2}$")]
    public string? PostCode { get; init; }

    [DataType(DataType.Date), Required, EmployeeDateOfBirthValidation]
    public DateTime DateOfBirth { get; init; }
}
