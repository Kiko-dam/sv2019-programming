/*
 PoundsConversor
 */
 
 using System;
 class PoundsConversor
 {
     static void Main()
     {
         int pounds, ounces, grams;
         
         Console.Write("How many pounds: ");
         pounds = Convert.ToInt32(Console.ReadLine() );
         
         ounces = pounds * 16;
         milligrams = pounds * 453592;
         
         grams = milligrams / 1000;
         thousandths = milligrams % 1000;
         
         Console.WriteLine("{0} pounds are {1} ounces", 
            pounds, ounces);
         Console.WriteLine("{0} pounds are {1}.{2} grams", 
            pounds, milligrams, thousandths);
     }
 }
