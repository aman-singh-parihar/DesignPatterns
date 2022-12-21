using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class TitaniumCardFactory : CardFactory
    {
        protected override Card CreateCard()
        {
            var card = new Platinum();
            return card;
        }
    }
}
