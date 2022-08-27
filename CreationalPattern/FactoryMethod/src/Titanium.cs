using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Titanium : Card
    {
        internal override int Limit { get => 40000; }
        internal override string Name { get => nameof(Titanium); }
        internal override CardType Type { get => CardType.CreditCard; }
    }
}
