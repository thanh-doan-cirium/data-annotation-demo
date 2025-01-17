using DataValidation.Models;
using DataValidation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataValidation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SalaryController(IPaymentService paymentService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PaySalary([FromBody] PaymentRequest paymentRequest)
    {
        var result = await paymentService.PayAsync(paymentRequest);
        return GetStatusCodeFromPayAsyncResponse(result);
    }

    private IActionResult GetStatusCodeFromPayAsyncResponse(PaymentResponse result)
    {
        if (result.Success)
        {
            return Ok(result);
        }
        else
        {
            return BadRequest(result);
        }
    }
}
