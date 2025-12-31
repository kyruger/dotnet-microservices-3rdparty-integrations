using Weather.Api.DTOS;

namespace Weather.Api.Service
{
    public interface IWeatherService
    {
        Task<WeatherDTO> GetWeatherAsync(string city);
    }
}
