using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingReflection
{
    public class Employee
    {
        public string name {  get; set; }

        public int salary { get; set; } 
        public string GetFUllName(string firstname,string lastname)
        {
            return firstname + " " + lastname;  
        }


        public Employee() 
        {
            this.name = "polin";
            this.salary = 1000;
        }
    }
}
