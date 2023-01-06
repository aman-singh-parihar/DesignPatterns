using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ContemporaryTable : ITable
    {
        internal ContemporaryTable()
        {
            Console.WriteLine("Contemporary table created.");
        }
    }
}
