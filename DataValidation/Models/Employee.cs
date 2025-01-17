using System.ComponentModel.DataAnnotations;
using DataValidation.Validations;

namespace DataValidation.Models;

public class Employee
{
    [Required, MinLength(3), MaxLength(30)]
    public string? FirstName { get; init; }

    [Required, MinLength(3), MaxLength(50)]
    public string? Surname { get; init; }

    [EmailAddress]
    public string? Email { get; init; }

    [RegularExpression("^([0-9]{5})$")]
    public string? ZipCode { get; init; }

    [DataType(DataType.Date), Required, EmployeeDateOfBirthValidation]
    public DateTime DateOfBirth { get; init; }
}
