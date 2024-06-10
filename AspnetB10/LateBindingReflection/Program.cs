using System.Reflection;

public class Proram
{
    public static void Main()
    {
        //Assembly assembly = Assembly.GetExecutingAssembly();

        //Type CustomerType = assembly.GetType("LateBindingReflection.Employee");

        //object EmployeeInstance = Activator.CreateInstance(CustomerType);


        //MethodInfo getfullmethod =  CustomerType.GetMethod("GetFUllName");

        //string[] Parameter = new string[2];

        //Parameter[0] = "Istiaque";
        //Parameter[1] = "Chowdhury";


        //string Fullname = (string)getfullmethod.Invoke(EmployeeInstance, Parameter);


        //Console.WriteLine(Fullname);


        Assembly assembly = Assembly.GetExecutingAssembly();


        Type GetConstructor =  assembly.GetType("LateBindingReflection.Employee");

        ConstructorInfo constructorInfo = GetConstructor.GetConstructor(new Type[] { });





       
    }
}