using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Square : IShape
    {
        public int Side { get; set; }   
        public double Calculate()
        {
            return Side * Side;
        }
    }
}
