using Microsoft.AspNetCore.Mvc;

namespace M223HelloWorld.Controllers;

[ApiController]
[Route("calculator")]
public class CalculatorController : Controller
{
    [HttpGet("add/{numberOne}/{numberTwo}")]
    public IActionResult Add(int numberOne, int numberTwo)
    {
        var result = numberOne + numberTwo;
        return Ok(result);
    }
}