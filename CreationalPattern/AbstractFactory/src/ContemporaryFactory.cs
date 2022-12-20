using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ContemporaryFactory : IFactory
    {
        public IChair CreateChair()
        {
            throw new NotImplementedException();
        }

        public ITable CreateTable()
        {
            throw new NotImplementedException();
        }
    }
}
