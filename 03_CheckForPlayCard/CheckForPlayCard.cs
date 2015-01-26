using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classical play cards use the following signs to designate the card face: 
 * `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
 *              Examples:
 *              
        character	Valid card sign?
            5	            yes
            1	            no
            Q	            yes
            q	            no
            P	            no
            10	            yes
            500	            no
 */

class CheckForPlayCard
{
    static void Main()
    {

        string userCard = Console.ReadLine();
    
        string yes = "Yes";

        switch (userCard)
        {
            case "2":                           // the full sintaxis of case 
                {
                    Console.WriteLine(yes);
                    break;
                }        
            case "3":                           // short expresion of case
                Console.WriteLine(yes);
                break;
            case "4":
                Console.WriteLine(yes);
                break;
            case "5":
                Console.WriteLine(yes);
                break;
            case "6":
                Console.WriteLine(yes);
                break;
            case "7":
                Console.WriteLine(yes);
                break;            
            case "8":
                Console.WriteLine(yes);
                break;            
            case "9":
                Console.WriteLine(yes);
                break;            
            case "10":
                Console.WriteLine(yes);
                break;            
            case "J":
                Console.WriteLine(yes);
                break;            
            case "Q":
                Console.WriteLine(yes);
                break;            
            case "K":
                Console.WriteLine(yes);
                break;
            case "A":
                Console.WriteLine(yes);
                break;
            default:                                // make sure most case do have default statement case
                Console.WriteLine("No"); 
                break;
        }
      
    }
}

