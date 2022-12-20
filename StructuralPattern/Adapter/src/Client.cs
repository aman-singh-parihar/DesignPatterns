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
        public Client(IExchangeRate exchange)
        {
            this._exchange = exchange;
        }
        public int Execute(int dollarAmount)
        {
            return _exchange.USDToINRExchange(dollarAmount);
        }
    }
}
