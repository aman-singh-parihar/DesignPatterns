﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernTable : ITable
    {
        internal ModernTable()
        {
            Console.WriteLine("Modern table created.");
        }
    }
}
