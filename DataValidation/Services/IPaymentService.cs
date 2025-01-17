using DataValidation.Models;

namespace DataValidation.Services;

public interface IPaymentService
{
    Task<PaymentResponse> PayAsync(PaymentRequest request);
}
