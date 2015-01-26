using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A beer time is after 1:00 PM and before 3:00 AM.
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
 * a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer 
 * time according to the definition above or invalid time if the time cannot be parsed. 
 * Note: You may need to learn how to parse dates and times.
 *                     
 *                     Examples:
                time	        result
                1:00 PM	        beer time
                4:30 PM	        beer time
                10:57 PM	    beer time
                8:30 AM	        non-beer time
                02:59 AM	    beer time
                03:00 AM	    non-beer time
                03:26 AM	    non-beer time
 */

class BeerTime
 {
     static void Main()
     {

         CultureInfo culture = CultureInfo.InvariantCulture;

         DateTime openTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", culture);
         DateTime closeTime = DateTime.ParseExact("03:00 PM", "hh:mm tt", culture);

         Console.WriteLine("Enter time in format \"hh:mm tt\" and we will see if you deserve a beer :");
         string userTime = Console.ReadLine();

         DateTime result;   // variable of type DateTime in which I will store the output from TryParseExact

         bool check = DateTime.TryParseExact(userTime, "h:mm tt", culture, DateTimeStyles.None, out result); 
         //using only h to ensure the program wont crash when no 0 is added to the time format

         //Console.WriteLine(result);   // for test remove later - will return the parsed time
         //Console.WriteLine(check);    
         // for test remove later - will return true if parse is OK and false instead of execption - using this for check before anything else

         if (check)
         {
             if (result.Hour < 3 || result.Hour >= 13)          //counting the hours in 24-hour format - beer tiem is after 13:00 and before 3>00
             {
                 Console.WriteLine("beer time");
             }
             else if (result.Hour >= 3 || result.Hour < 13)
             {
                 Console.WriteLine("non beer time");
             }
             else
             {
                 Console.WriteLine("invalid time");
             }
         }
         else
         {
             Console.WriteLine("invalid time");
         }
         
     }
 }

