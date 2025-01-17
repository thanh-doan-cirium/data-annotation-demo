using DataValidation.Models;

namespace DataValidation.Validations;

public interface IPaymentValidator
{
    Task ValidateAndThrowAsync(PaymentRequest request);
}