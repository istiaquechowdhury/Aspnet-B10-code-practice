using JsonPractice;

public class Program
{
    public static void Main()
    {
        Person person = new Person
        {
            Name = Console.ReadLine(),
            age = int.Parse(Console.ReadLine()),
            Phone = Console.ReadLine(),

            Address = new Address
            {
                Zip = Console.ReadLine(),
                PostalCode = int.Parse(Console.ReadLine()),
                Country = Console.ReadLine(),
                City = Console.ReadLine()
            },

            //hobbies = {"Travelling","biking","hiking"},
            //cars = new string[]
            //{
            //    "mercedes",
            //    "Land cuiser",
            //},
           

        };

        var json = new JsonSerializer();

        string s = json.Serializer(person);
        Console.WriteLine(s);

    }
}