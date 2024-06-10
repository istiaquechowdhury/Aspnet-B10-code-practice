using Reflection;
using System.Reflection;


public class Program
{
    public static void Main()
    {


        //Type type = Type.GetType("Reflection.Customer");
        //Console.WriteLine(type.FullName);
        //Console.WriteLine(type.Name);
        //Console.WriteLine(type.Namespace);

        //PropertyInfo[] properties = type.GetProperties();

        //Console.WriteLine("-----------");
        //Console.WriteLine("Properties");
        //Console.WriteLine("-----------");

        //foreach (PropertyInfo property in properties)
        //{
        //    Console.WriteLine(property.PropertyType.Name +" " + property.Name);
        //}

        //Console.WriteLine("-----------");
        //Console.WriteLine("Constructors");
        //Console.WriteLine("-----------");

        //ConstructorInfo[] constructors = type.GetConstructors();

        //foreach (ConstructorInfo constructor in constructors)
        //{
        //    Console.WriteLine(constructor.ToString());
        //}

        //Console.WriteLine("-----------");
        //Console.WriteLine("Methods");
        //Console.WriteLine("-----------");

        //MethodInfo[] methods = type.GetMethods();

        //foreach (MethodInfo method in methods)
        //{
        //    Console.WriteLine(method.ReturnType.Name +" " + method.Name);
        //}



        string UserInput = Console.ReadLine();

        Type type;

        if (UserInput == "string")
        {
            type = typeof(string);
        }
        else if (UserInput == "double")
        {
            type = typeof(double);
        }
        else if (UserInput == "char")
        {
            type = typeof(char);
        }
        else if (UserInput == "bool")
        {
            type = typeof(bool);
        }
        else if (UserInput == "Console") 
        {
            type = typeof(Console);
        }
        else
        {
            type = Type.GetType(UserInput);
        }
       


        MethodInfo[] methods = type.GetMethods();
       
        foreach (MethodInfo m in methods)
        {
            Console.WriteLine(m.Name);
        }
    }
}