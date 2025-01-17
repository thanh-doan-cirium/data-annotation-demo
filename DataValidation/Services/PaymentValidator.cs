using DataValidation.Exceptions;
using DataValidation.Models;

namespace DataValidation.Services;

public class PaymentValidator : IPaymentValidator
{
    public async Task ValidateAndThrowAsync(PaymentRequest request)
    {
        if (request.Amount <= 0)
        {
            throw new ValidationException("Amount must be greater than 0");
        }

        if (string.IsNullOrEmpty(request.AccountNumber))
        {
            throw new ValidationException("AccountNumber must be provided");
        }
    }
}