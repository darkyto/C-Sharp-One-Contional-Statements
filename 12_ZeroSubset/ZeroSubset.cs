using System;

/*
 * We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
 * Assume that repeating the same subset several times is not a problem.
 *                      
 *                          Examples:

                    numbers	                    result
                    3 -2 1 1 8	            -2 + 1 + 1 = 0
                    3 1 -7 35 22    	    no zero subset
                    1 3 -4 -2 -1    	        1 + -1 = 0
                                             1 + 3 +-4 = 0
                                           3 + -2 + -1 = 0
                    1 1 1-1-1	                1 + -1 = 0
                                        1 + 1 +-1 + -1 = 0
                    0 0 0 0 0	     0 + 0 + 0 + 0 + 0 = 0
 * 
 * 
 *  1-5/5  5-4/5  10-3/5  10-2/5  5-1/5 
 * 
 */

class ZeroSubset
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int subsetCounter = 0;

        if ((a+b+c+d+e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{2}+{3}+{4}={5}", a, b, c, d, e, a+b+c+d+e);
        }
        if ((a + b + c + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{2}+{3}={5}", a, b, c, d, e, a + b + c + d);
        }
        if ((a + b + c + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{2}+{4}={5}", a, b, c, d, e, a + b + c + e);
        }
        if ((a + b + d + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{3}+{4}={5}", a, b, c, d, e, a + b + d + e);
        }
        if ((a + c + d + e) == 0)
        {
            Console.WriteLine(" {0}+{2}+{3}+{4}={5}", a, b, c, d, e, a + c + d + e);
            subsetCounter++;
        }
        if ((b + c + d + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{2}+{3}+{4}={5}", a, b, c, d, e, b + c + d + e);
        }
        if ((a + b + c) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{2}={5}", a, b, c, d, e, a + b + c);
        }
        if ((a + b + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{3}={5}", a, b, c, d, e, a + b + d);
        }
        if ((a + b + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}+{4}={5}", a, b, c, d, e, a + b + e);
        }
        if ((a + c + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{2}+{3}={5}", a, b, c, d, e, a + c + d);
        }
        if ((a + c + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{2}+{4}={5}", a, b, c, d, e, a + c + e);
        }
        if ((a + d + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{3}+{4}={5}", a, b, c, d, e, a + d + e);
        }
        if ((b + c + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{2}+{3}={5}", a, b, c, d, e, b + c + d);
        }
        if ((b + c + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{2}+{4}={5}", a, b, c, d, e, b + c + e);
        }
        if ((b + d + e) == 0)
        {
            Console.WriteLine(" {1}+{3}+{4}={5}", a, b, c, d, e, b + d + e);
        }
        if ((c + d + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {2}+{3}+{4}={5}", a, b, c, d, e, c + d + e);
        }
        if ((a + b) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{1}={5}", a, b, c, d, e, a + b);
        }
        if ((a + c) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{2}={5}", a, b, c, d, e, a + c);
        }
        if ((a + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{3}={5}", a, b, c, d, e, a + d);
        }
        if ((a + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {0}+{4}={5}", a, b, c, d, e, a + e);
        }
        if ((b + c) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{2}={5}", a, b, c, d, e, b + c);
        }
        if ((b + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{3}={5}", a, b, c, d, e, b + d);
        }
        if ((b + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {1}+{4}={5}", a, b, c, d, e, b + e);
        }
        if ((c + d) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {2}+{3}={5}", a, b, c, d, e, c + d);
        }
        if ((c + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {2}+{4}={5}", a, b, c, d, e, c + e);
        }
        if ((d + e) == 0)
        {
            subsetCounter++;
            Console.WriteLine(" {3}+{4}={5}", a, b, c, d, e, d + e);
        }
        if (subsetCounter==0)
        {
            Console.WriteLine(" No zero subset");
        }
        // Console.WriteLine("Total number of zero subsets combinations :{0}",subsetCounter);  //for test
    }
}


//if (a== 0)
//{
//    subsetCounter++;
//    Console.WriteLine(" {0}={0}", a, b, c, d, e);
//}
//if (b == 0)
//{
//    subsetCounter++;
//    Console.WriteLine(" {1}={1}", a, b, c, d, e, d + e);
//}
//if (c == 0)
//{
//    subsetCounter++;
//    Console.WriteLine(" {2}={2}", a, b, c, d, e, d + e);
//}
//if (d == 0)
//{
//    subsetCounter++;
//    Console.WriteLine(" {3}={3}", a, b, c, d, e, d + e);
//}
//if (e == 0)
//{
//    subsetCounter++;
//    Console.WriteLine(" {4}={4}", a, b, c, d, e, d + e);
//}
