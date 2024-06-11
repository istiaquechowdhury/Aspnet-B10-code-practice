using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Circle
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
