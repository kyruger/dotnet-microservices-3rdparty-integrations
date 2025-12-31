using System.Runtime.CompilerServices;
using Weather.Api.DTOS;

namespace Weather.Api.Service
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public WeatherService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
            _httpClient.BaseAddress = new Uri(_config["WeatherApi:BaseUrl"]);
        }

        public async Task<WeatherDTO> GetWeatherAsync(string city)
        {
            var apiKey = _config["WeatherApi:ApiKey"];
            var response =await _httpClient.GetAsync($"weather?q={city}&appid={apiKey}&units=metric");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<WeatherDTO>();
        }
   
    }
}
    

