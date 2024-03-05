using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal abstract class AbstractHandler : IHandler
    {
        internal IHandler _nextHandler;

        public abstract void Handle(string incoming);

        public void SetNextHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

    }
}
