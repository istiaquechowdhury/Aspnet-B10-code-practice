using SRP;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {

        Circle c = new Circle(5);

        double d = c.Calculate();

        Console.WriteLine(d);

        new Print().PrintRadius(c.radius);
            

         //Every classes in this SRP is doing only one thing related to that class only.

    }

   
}