using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the biggest of five numbers by using only five if statements.
                        
 *                  Examples:
            
            a	    b	    c	    d	    e	    biggest
            5	    2	    2	    4	    1	    5
            -2	    -22	    1	    0	    0	    1
            -2	    4	    3	    2	    0	    4
            0	    -2.5	0	    5	    5	    5
            -3	    -0.5	-1.1	-2	 -0.1	    -0.1
 * 
 * 
 *       !!!   USE IF-ELSE and NO MORE THEN 5 IFs   !!!
 */

class BiggestFiveNumbers
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());

        bool aBig = (a >= b) & (a >= c) & (a >= d) & (a >= e);       // declaring 5 boolean variables each
        bool bBig = (a <= b) & (b >= c) & (b >= d) & (b >= e);       // of which checks if its number is larger/equal to all others
        bool cBig = (c >= b) & (a <= c) & (c >= d) & (c >= e);       // even if we have 2 or more members that are equal and with the biggest
        bool dBig = (d >= b) & (d >= c) & (a <= d) & (d >= e);       // value it will still return true - which is ok because we need just
        bool eBig = (e >= b) & (e >= c) & (e >= d) & (a <= e);       // the biggest value no matter which members has it!

        string theBiggest = "The biggest number is :";

        if (aBig)
        {
            Console.WriteLine(theBiggest + a);
        }
        else if (bBig)
        {
            Console.WriteLine(theBiggest + b);
        }
        else if (dBig)
        {
            Console.WriteLine(theBiggest + d);
        }
        else if (cBig)
        {
            Console.WriteLine(theBiggest + c);
        }
        else if (eBig)
        {
            Console.WriteLine(theBiggest + e);
        }


        /* Variant with while loop but we CANT usse boolen for statement inside the while

        while ((a >= b) & (a >= c) & (a >= d) & (a >= e))
        {
            Console.WriteLine(theBiggest + a);
            break;
        }
        while ((a <= b) & (b >= c) & (b >= d) & (b >= e))
        {
            Console.WriteLine(theBiggest + b);
            break;
        }
        while ((c >= b) & (a <= c) & (c >= d) & (c >= e))
        {
            Console.WriteLine(theBiggest + c);
            break;
        }
        while ((d >= b) & (d >= c) & (a <= d) & (d >= e))
        {
            Console.WriteLine(theBiggest + d);
            break;
        }
        while ((e >= b) & (e >= c) & (e >= d) & (a <= e))
        {
            Console.WriteLine(theBiggest + e);
            break;
        }
         * 
         */
    }
}

