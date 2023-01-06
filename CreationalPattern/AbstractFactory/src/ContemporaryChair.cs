using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ContemporaryChair : IChair
    {
        internal ContemporaryChair() 
        {
            Console.WriteLine("Contemporary chair created.");
        }
    }
}
