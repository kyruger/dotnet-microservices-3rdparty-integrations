namespace Currency.Api.Services
{
    public interface ICurrencyService
    {
        Task<decimal> ConvertAsync(string from, string to, decimal amount);
    }
}
