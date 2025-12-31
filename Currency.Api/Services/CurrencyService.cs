
using Currency.Api.DTOs;

namespace Currency.Api.Services
{
    public class CurrencyService:ICurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;  
        }

        public async Task<decimal> ConvertAsync(string from, string to, decimal amount)
        {
            var response = await _httpClient.GetFromJsonAsync<CurrencyConvertResponseDTO>($"latest?amount={amount}&from={from}&to={to}");

            if (response == null)
            {
                throw new Exception("Failed to get currency conversion data.");
            }
            return response.Rates[to];

        }

    }
}
    