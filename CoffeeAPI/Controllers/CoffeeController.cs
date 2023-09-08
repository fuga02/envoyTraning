using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class CoffeeController : ControllerBase
{
    private static readonly string[] Coffee = new[]
    {
        "Flat White", "Long Black", "Latte", "Americano","Cappuccino"
    };

    [HttpGet]
    public ActionResult Get()
    {
        var rng = new Random();

        return Ok(Coffee[rng.Next(Coffee.Length)]);
    }
}