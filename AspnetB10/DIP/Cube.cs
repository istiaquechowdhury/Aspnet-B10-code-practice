using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Cube : I3Dshape
    {
        public int side {  get; set; }
        public double Getvolume()
        {
            return side * side * side;
        }
    }
}
