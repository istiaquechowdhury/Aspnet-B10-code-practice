using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Customer
    {
        public string Name { get; set; }    

        public string Address { get; set; }

        public Customer(string Name, string Address)
        {
            this.Address = Address;
            this .Name = Name;
        }

        public Customer()
        {
            this.Address = "skdjfks";
            this.Name = "istiaque";
        }

        public void GetName(string name)
        {
            Console.WriteLine($"{Name}");
        }

        public void GetAddress(string address)
        {
            Console.WriteLine($"{Address}");
        }
    }

}
