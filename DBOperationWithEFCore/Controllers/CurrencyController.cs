using DBOperationWithEFCore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBOperationWithEFCore.Controllers
{
    [Route("api/Currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDBContext _AppDB;
        public CurrencyController(AppDBContext appDBContext)
        {
            this._AppDB = appDBContext;
        }

        [HttpGet]
        public IActionResult GetCurrencies()
        {
            //var currencies = this._AppDB.Currencies.ToList();

            //LInQ Query
            var currencies = (from curr in this._AppDB.Currencies
                              select curr).ToList();

            return Ok(currencies);
        }
    }
}
