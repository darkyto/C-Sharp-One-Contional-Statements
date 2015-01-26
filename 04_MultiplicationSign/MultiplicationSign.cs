using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of if operators.
 * 
 *                      Examples:

            a	    b	    c	    result
            5	    2	    2	    +
            -2	    -2	    1	    +
            -2	    4	    3	    -
            0	    -2.5	4	    0
            -1	    -0.5	-5.1	-
 * 
 */

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool noNull = (a != 0) & (b != 0) & (c != 0);   // special check to confirm none of the numbers is 0

        if (noNull)                                     // after check for 0 we are going to the through check of the product without calculating
        {
            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else                            //  will return this if 0 is among the numbers
        {
            Console.WriteLine("0");
        }

        
    }
}

