using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ClassicChair : IChair
    {
        internal ClassicChair()
        {
            Console.WriteLine("Classic chair created.");
        }
    }
}
