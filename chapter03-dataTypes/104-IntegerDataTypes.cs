// Integer data types
// Saúl Cánovas Navarro

using System;

class IntegerDataTypes
{
    static void Main()
    {
        byte age;
        ushort yearOfBirth;
        uint population;
        long savings;

        Console.Write("Enter your age: ");
        age = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter your year of birth: ");
        yearOfBirth = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Enter the population of your city: ");
        population = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Enter your savings: ");
        savings = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine(
            "Age: {0} Year: {1} Population: {2} Savings: {3}", 
            age, yearOfBirth, population, savings);
    }
}
