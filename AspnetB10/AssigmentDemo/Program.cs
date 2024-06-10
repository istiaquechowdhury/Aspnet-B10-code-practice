using AssigmentDemo;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        var serializer = new JsonSerializer();
        var obj = new Example
        {
            Name = "John",
            Age = 30,
            IsStudent = true,
            Birthday = new DateTime(1990, 1, 1),
            Friends = new List<string> { "Alice", "Bob", "Charlie" }
        };

        string json = serializer.Serialize(obj);
        Console.WriteLine(json);
    }
}