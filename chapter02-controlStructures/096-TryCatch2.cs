// Diego Aníbal Lezcano Reissner

using System;

class TryCatch
{
    static void Main()
    {
        int n1=0, n2=0;
        try
        {
            Console.Write("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} / {1} = {2}", n1, n2, n1/n2);
            Console.WriteLine("{0} x {1} = {2}", n1, n2, n1*n2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0.");
            Console.WriteLine("But {0} x {1} = {2}", n1, n2, n1*n2);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format");
        }

    }
}
