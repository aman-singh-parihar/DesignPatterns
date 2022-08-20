using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class CardFactory
    {
        protected abstract Card CreateCard();
        public Card Card { get => this.CreateCard(); }
    }
}
