using DataValidation.Models;

namespace DataValidation.Services;

public interface IPaymentValidator
{
    Task ValidateAndThrowAsync(PaymentRequest request);
}