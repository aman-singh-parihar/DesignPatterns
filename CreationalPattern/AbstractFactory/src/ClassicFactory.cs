using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ClassicFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new ClassicChair();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}
