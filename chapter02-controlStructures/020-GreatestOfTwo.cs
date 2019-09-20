//Jose Valera

class GreatestNumber
{
    static void Main()
    {
        int n1, n2, greatest;

        System.Console.Write("Enter a number: ");
        n1=System.Convert.ToInt32(
            System.Console.ReadLine() );
        System.Console.Write("Enter another: ");
        n2=System.Convert.ToInt32(
            System.Console.ReadLine() );

        if (n1 >= n2)
        {
            greatest = n1;
        }
        else
        {
            greatest = n2;
        }
        
        System.Console.Write("The greatest number is: ");
        System.Console.WriteLine(greatest);
    }
}
