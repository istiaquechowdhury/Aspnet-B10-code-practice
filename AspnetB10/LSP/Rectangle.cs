using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LSP
{
    internal class Rectangle : IShape
    {
        public int length {  get; set; }    

        public int width { get; set; }  

        public double Calculate()
        {
            return length * width;
        }

        
    }
}
