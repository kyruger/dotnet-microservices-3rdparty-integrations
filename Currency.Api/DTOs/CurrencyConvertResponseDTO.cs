using System.Text.Json.Serialization;

namespace Currency.Api.DTOs
{
    public class CurrencyConvertResponseDTO
    {
        public Dictionary<string, decimal> Rates { get; set; }

    }
}
