/*Renato Bueno Amoros
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
         grams = pounds * 453592;
         
         Console.WriteLine("{0} pounds are {1} ounces", 
            pounds, ounces);
         Console.WriteLine("{0} pounds are {1} grams", 
            pounds, grams * 1.0 / 1000);
     }
 }
