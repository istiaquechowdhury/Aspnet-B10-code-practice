using System.Net.Sockets;

namespace AssignmentSolution1Practice
{
    public class Teacher
    {
        public int Id { get; set; }
        public double number { get; set; }
       
        public decimal number2 { get; set; }

        public bool islazy { get; set; }

        public string Name { get; set; }

        public DateTime dateTime { get; set; }
        public char c { get; set; }

        public string[] houses{  get; set; }
        public string[,] salary { get; set; }


        public string[,,] salary2 { get; set; }

        public int[][] jaggedarray { get; set; }


        public List<Address> Address { get; set; }
       
        public Course Course { get; set; }  


    }

    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
    }

    public class Address
    {
        public int id { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }
    }

    public class Country
    {
        public int id { get; set; }

        public string Name { get; set; }
        public building building { get; set; }

    }

    public class building
    {
        public int id { get; set; }

        public string Name { get; set; }

        public Cartoon Cartoon { get; set; }


    }

    public class Cartoon
    {
        public int id { get; set; }

        public string Name { get; set; }

        public A A { get; set; }


    }
    public class A
    {
        public int id { get; set; }

        public string Name { get; set; }

        public B B { get; set; }

    }
    public class B
    {
        public int id { get; set; }

        public string Name { get; set; }

        public C C { get; set; }
    }
    public class C
    {
        public int id { get; set; }

        public string Name { get; set; }

        public D D { get; set; }    
    }
    public class D
    {
        public int id { get; set; }

        public string Name { get; set; }

        public E E { get; set; }

    }
    public class E
    {
        public int id { get; set; }

        public string Name { get; set; }

        public F F{ get; set; }



    }
    public class F
    {
        public int id { get; set; }

        public string Name { get; set; }

        public G G { get; set; }


    }
    public class G
    {
        public int id { get; set; }

        public string Name { get; set; }

        public H H { get; set; }


    }
    public class H
    {
        public int id { get; set; }

        public string Name { get; set; }

        public I I  { get; set; }


    }
    public class I
    {
        public int id { get; set; }

        public string Name { get; set; }

        public J J { get; set; }


    }
    public class J
    {
        public int id { get; set; }

        public string Name { get; set; }
        public K K { get; set; }


    }
    public class K
    {
        public int id { get; set; }

        public string Name { get; set; }

        public L L { get; set; }


    }
    public class L
    {
        public int id { get; set; }

        public string Name { get; set; }

        public M M { get; set; }


    }
    public class M
    {
        public int id { get; set; }

        public string Name { get; set; }

        public char c { get; set; } 

    }



}