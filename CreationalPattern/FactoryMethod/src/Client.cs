using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Client
    {
        private readonly CardFactory _cardFactory;
        internal Client(CardFactory cardFactory) 
        {
            _cardFactory = cardFactory;
        }
        internal Card GetCard() 
        {
            return _cardFactory.Card;
        }
    }
}
