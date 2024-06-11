using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP

{
    internal class Printer : IPrinter
    {
        public void Print(IShape circle)
        {
            Console.WriteLine(circle);
        }
    }
}
