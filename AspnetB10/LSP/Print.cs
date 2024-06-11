using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP

{
    internal class Print
    {
        public void PrintRadius(IShape shape)
        {
            
            Console.WriteLine(shape);    
        }
    }
}
