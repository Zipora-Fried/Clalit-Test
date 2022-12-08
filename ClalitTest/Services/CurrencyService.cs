using Newtonsoft.Json;
using System.Xml;

namespace ClalitTest.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ILogger<CurrencyService> _logger;

        public CurrencyService(ILogger<CurrencyService> logger) => _logger = logger;
      
        public IEnumerable<Currency>? GetNegativeCurrencies()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("https://www.boi.org.il/currency.xml");

                var json = JsonConvert.SerializeXmlNode(doc);
                var currencyData = JsonConvert.DeserializeObject<CurrenciesData>(json);

                return currencyData?.Currencies.Currency.Where(currency => currency.Change < 1);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load currencies");
                throw;
            }
        }
    }
}
