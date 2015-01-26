using System;
using System.Linq;

/*
 * Write a program that finds the biggest of three numbers.
 * 
 *          Examples:

        a	    b	    c    biggest
        5	    2	    2	    5
       -2	   -2	    1	    1
       -2	    4	    3	    4
        0	 -2.5	    5	    5
     -0.1	 -0.5	 -1.1	 -0.1
 */

class TheBiggest3Numbers
   {
       static void Main()
       {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           double c = double.Parse(Console.ReadLine());

           Console.WriteLine(Math.Max(Math.Max(a, b), c));                 // using Linq
           // Math.Max twice in a row for comparison of a and b and then the larger to c


           // SECOND variant below with the use of array and Max() - this way we can compare the members of big arrays
           //double[] userNums = new double[3];
           //userNums[0] = double.Parse(Console.ReadLine());
           //userNums[1] = double.Parse(Console.ReadLine());
           //userNums[2] = double.Parse(Console.ReadLine());

           //double theWinner = userNums.Max();
           //Console.WriteLine(theWinner);


           ////THIRD variant with if-else statement
           //bool notEqual = (a != b) & (b != c) & (c != a); // make sure that two members do not have equak values

           //if (notEqual)
           //{
           //    if (a > b & a > c)
           //    {
           //        Console.WriteLine(a);
           //    }
           //    else if (b > a & b > c)
           //    {
           //        Console.WriteLine(b);
           //    }
           //    else if (c > a & c > b)
           //    {
           //        Console.WriteLine(c);
           //    }
           //}
           //else                             // here I will make the check if we have equal members
           //{
           //    if (a == b & a > c)
           //    {
           //        Console.WriteLine(a);
           //    }
           //    else if (a == b & a < c)
           //    {
           //        Console.WriteLine(c);
           //    }
           //    else if (a == c & a > b)
           //    {
           //        Console.WriteLine(a);
           //    }
           //    else if (a == c & a < b)
           //    {
           //        Console.WriteLine(b);
           //    }
           //    else if  (a == c & a == b)
           //    {
           //        Console.WriteLine(a);
           //    }
           //}
       }
   }

