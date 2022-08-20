using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Card
    {
        internal abstract int Limit { get; }
        internal abstract string Name { get; }
        internal abstract CardType Type { get; }
    }
}
