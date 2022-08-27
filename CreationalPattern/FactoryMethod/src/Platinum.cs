using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Platinum : Card
    {
        internal override int Limit { get => 40000; }
        internal override string Name { get => nameof(Platinum); }
        internal override CardType Type { get => CardType.DebitCard; }
    }
}
