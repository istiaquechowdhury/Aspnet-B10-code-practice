using ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Circle : IShape
    {
        public int radius {  get; set; }    


        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Calculate()
        {
            return double.Pi * radius * radius;
        }

       
       
       
    }
    
}
