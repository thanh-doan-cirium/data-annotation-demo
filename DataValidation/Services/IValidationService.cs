using DataValidation.Models;

namespace DataValidation.Services;
public interface IValidationService
{
    Task ValidateAsync(PaymentRequest request);
}
