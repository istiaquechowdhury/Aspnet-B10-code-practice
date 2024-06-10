using System.Reflection;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter The FullyQualified Class Name(Ex-System.String,ReflectionQuestion2.Calculator):");

        string ClassName = Console.ReadLine();

        Console.WriteLine("Enter the MethodName:Add or Messeage");

        string MethodName = Console.ReadLine();

        Assembly Assembly = Assembly.GetExecutingAssembly();

        Type Class = Assembly.GetType(ClassName);

        object instance = Activator.CreateInstance(Class);

        MethodInfo Method = Class.GetMethod(MethodName);

        if(Method == null)
        {
            Console.WriteLine("Invalid Method Name");
            return;
        }

        if(Method.GetParameters().Length == 0)
        {
            object obj = Method.Invoke(instance, null);
            Console.WriteLine(obj);
        }
        else
        {
            Console.WriteLine("Enter Parameter value:");

            string[] s = Console.ReadLine().Split();
            
            double[] arr = Array.ConvertAll(s, double.Parse);

            double a = arr[0];
            double b = arr[1];

            object obj = Method.Invoke(instance, new object[] { a,b });
            Console.WriteLine(obj);
        }

        
    }
}