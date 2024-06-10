using System.Reflection;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Give the fullyqualified class name");

        string UserInput = Console.ReadLine();  


        Type T = Type.GetType(UserInput);

        if(T == null )
        {
            Console.WriteLine("This is not the fullyqualified class name");
            return;
        }
        else
        {
            MethodInfo[] Methods = T.GetMethods();

            foreach (MethodInfo method in Methods)
            {
                Console.WriteLine(method.Name);
            }

        }
        
    }
}