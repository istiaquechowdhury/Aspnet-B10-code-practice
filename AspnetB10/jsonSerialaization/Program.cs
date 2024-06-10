using jsonSerialaization;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var person = new Person
        {
            Name = "John Doe",
            Age = 30,
            Email = "john@example.com"
        };

        var serializer = new JsonSerializar();
        string json = serializer.SerializeObject(person);
        Console.WriteLine(json);

        Customer cust = new Customer
        {
            Id = int.Parse(Console.ReadLine()),
            Name = "istiaque",
            Address = "slkdjfkl"

        };
        var serial = new JsonSerializar();
        string json2 = serial.SerializeObject(cust);
        Console.WriteLine(json2);

    }
}