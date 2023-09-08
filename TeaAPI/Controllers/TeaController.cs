using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class TeaController : ControllerBase
{
    private static readonly string[] Teas = new[]
    {
        "Green","Peppermit","Early Grey", "English Breakfast", "Camomile"
    };

    [HttpGet]
    public ActionResult Get()
    {
        var rng = new Random();

        return Ok(Teas[rng.Next(Teas.Length)]);
    }
}