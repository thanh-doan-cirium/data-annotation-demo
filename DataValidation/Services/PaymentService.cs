using DataValidation.Models;

namespace DataValidation.Services;

public class PaymentService(IValidationService validationService) : IPaymentService
{
    public async Task<PaymentResponse> PayAsync(PaymentRequest request)
    {
        try
        {
            await validationService.ValidateAsync(request);
        }
        catch
        {
            return new PaymentResponse { Success = false };
        }

        return new PaymentResponse { Success = true };
    }
}