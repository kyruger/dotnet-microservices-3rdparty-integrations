using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Weather.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly Service.IWeatherService _weatherService;
        public WeatherController(Service.IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            var result = await _weatherService.GetWeatherAsync(city);
            return Ok(result);
        }
    }
}
