using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client
    {
        private readonly IFactory factory;

        internal Client(IFactory factory) 
        {
            this.factory = factory;
        }
        internal IChair CreateChair()
        {
            return factory.CreateChair();
        }
        internal ITable CreateTable()
        { 
            return factory.CreateTable();
        }
    }
}
