using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        private readonly IExchangeRate _exchange;
        internal Client(IExchangeRate exchange)
        {
            this._exchange = exchange;
        }
        public void Execute()
        {
            _exchange.INRToUSDExchange();
        }
    }
}
