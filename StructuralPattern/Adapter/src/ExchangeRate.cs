using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ExchangeRate : IExchangeRate
    {
        private readonly ExchangeRateManager _exchange;
        public ExchangeRate(ExchangeRateManager exchange)
        {
            this._exchange = exchange;
        }
        public void INRToUSDExchange()
        {
            this._exchange.CurrentINRToUSDExchange();
        }
    }
}
