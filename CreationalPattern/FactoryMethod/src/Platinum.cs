using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Platinum : Card
    {
        protected override int Limit { get => 40000; }
        protected override string Name { get => nameof(Platinum); }
        protected override CardType Type { get => CardType.DebitCard; }
    }
}
