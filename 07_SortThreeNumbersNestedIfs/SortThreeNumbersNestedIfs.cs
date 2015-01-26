using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
 * Note: Don’t use arrays and the built-in sorting functionality.

        Examples:
        
        a	    b	    c	    result
        5	    1	    2	    5 2 1
        -2	    -2	    1	    1 -2 -2
        -2	    4	    3	    4 3 -2
        0	    -2.5	5	    5 0 -2.5
        -1.1	-0.5	-0.1	-0.1 -0.5 -1.1
        10	    20	    30	    30 20 10
        1	    1	    1	    1 1 1
 */
class SortThreeNumbersNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool isAbigger = (a >= b) & (a >= c);   //three booleans to check which is the Biggest number
        bool isBbigger = (b > a) & (b >= c);    //notice that we use only three = statemnts to avoid overlappping
        bool isCbigger = (c > b) & (c > a);

        if (isAbigger)
        {
            bool checkBC = b >= c;          // now that we know that A is the biggest we need to know which comes second
            if (checkBC)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);          // if b is in second place
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);          // if c is in second place
            }
        }
        else if (isBbigger)
        {
            bool checkAC = a >= c;
            if (checkAC)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else if (isCbigger)
        {
            bool checkAB = a >= b;
            if (checkAB)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }

    }
}

