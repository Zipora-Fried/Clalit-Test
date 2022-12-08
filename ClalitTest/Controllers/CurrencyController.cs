using ClalitTest.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;

namespace ClalitTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ILogger<CurrencyController> logger, ICurrencyService currencyService)
        {
            _logger = logger;
            _currencyService = currencyService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var negCurrencies = _currencyService.GetNegativeCurrencies();
                return Ok(negCurrencies);
            } catch (Exception ex)
            {
                _logger.LogError("Faild to get currencies");
                throw new Exception("CurrencyController - Faild to get currencies", ex);
            }
           
        }
    }
}