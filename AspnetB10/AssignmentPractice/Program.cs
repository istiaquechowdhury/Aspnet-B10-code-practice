using AssignmentPractice;
using System.Reflection;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Product p = new Product
        {
            Id = 1,
            Name = "Test",
        };

        Type type = typeof(Product);

        PropertyInfo[] pinfo = type.GetProperties();


        foreach (PropertyInfo pinfo2 in pinfo)
        {
           Console.WriteLine( pinfo2.GetValue(p) );    
        }

      
    }
}