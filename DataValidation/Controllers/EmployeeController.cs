using DataValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataValidation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Employee employeeModel)
    {
        return Ok(employeeModel);
    }
}
