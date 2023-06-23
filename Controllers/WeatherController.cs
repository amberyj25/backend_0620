using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet(Name = "GetWeather")]
    
    public Weather Get()
    {
        var index = 1;
        var weather = new Weather
        {
            Title = "weather contoller",
            Num = 5,
            Count = 1,
            Text = index
        };
        return weather;
    }
}