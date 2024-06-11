using DIP;

using System.Transactions;

public class Program
{
    public static void Main()
    {
        IShape c = new Circle(5);

        double d = c.Calculate();

        Console.WriteLine(d);

        IPrinter printer = new Printer();

        printer.Print(c);

        c = new Rectangle()
        {
            length = 5,
            width = 5,
        };

        double rd = c.Calculate();

        Console.WriteLine(rd);



        c = new Triangle()
        {
            a = 5,
            b = 5,
            c = 5
        };

        double t = c.Calculate();
        Console.WriteLine(t);

        c = new Square()
        {
            Side = 1,
        };
        Console.WriteLine(c);

        I3Dshape shape = new Cube
        {
            side = 1,
        };


}   }