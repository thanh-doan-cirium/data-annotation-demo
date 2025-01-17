using DataValidation.Models;
using DataValidation.Validations;

namespace DataValidation.Services;

public class ValidationService(IPaymentValidator validator) : IValidationService
{
    public async Task ValidateAsync(PaymentRequest request)
    {
        await validator.ValidateAndThrowAsync(request);
    }
}
