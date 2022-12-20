using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ExchangeRateManager
    {
        public int CurrentUSDToINRExchange(int dollarAmount) 
        {
            return dollarAmount * 80;
        }
    }
}
