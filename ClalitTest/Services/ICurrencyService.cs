namespace ClalitTest.Services
{
    public interface ICurrencyService
    {
        public IEnumerable<Currency>? GetNegativeCurrencies();
    }
}
