using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Triangle : IShape
    {
        public int a { get; set; }  
        public int b { get; set; }  
        public int c { get; set; }

        public double Calculate()
        {
            return a * b * c;
        }
    }
}
