using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ReflectionQuestion2
{
    public class Calculator
    {
        public double add(double x, double y)
        {
            return x + y;   
        }


        public void message() 
        {
            Console.WriteLine("I love Programming!");  
        }

    }
}
