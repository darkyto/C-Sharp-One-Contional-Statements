using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * divided.zero
 * 
 * Write a program that converts a number in the range [0…999] to words, 
 * corresponding to the English pronunciation.
               
 *           Examples:
 *           
        numbers	    number as words
        0	        Zero
        9	        Nine
        10	        Ten
        12	        Twelve
        19	        Nineteen
        25	        Twenty five
        98	        Ninety eight
        98	        Ninety eight
        273	        Two hundred and seventy three
 */

class NumberAsWords
{
    static void Main(string[] args)
    {
        string userChoice = Console.ReadLine();                 
        int userNumber;                                         // key variable which converts userChoice to int

        bool result = int.TryParse(userChoice, out userNumber); // userNumber is now an int and we have a bool check for that
            
        string[] digits = new string[10];       // array for 0-9 special cases   
        digits[0] = "zero";
        digits[1] = "one";
        digits[2] = "two";
        digits[3] = "three";
        digits[4] = "four";
        digits[5] = "five";
        digits[6] = "six";
        digits[7] = "seven";
        digits[8] = "eight";
        digits[9] = "nine";

        string t = "teen";          
        string[] toTwenty = new string[10];     // array for 10-19 - second group special cases
        toTwenty[0] = "ten";
        toTwenty[1] = "eleven";
        toTwenty[2] = "twelve";
        toTwenty[3] = "thirdteen";
        toTwenty[4] = digits[4] + t;
        toTwenty[5] = "fifteen";
        toTwenty[6] = digits[6] + t;
        toTwenty[7] = digits[7] + t;
        toTwenty[8] = digits[8] + t;
        toTwenty[9] = digits[9] + t;

        string tenAd = "ty";
        string[] allTens = new string[10];      // array for the tens - making the array as human logic ( 2 for twenty)
        allTens[0] = "";                        // so that I can later call the elements with more ease and intuition
        allTens[1] = "ten"; 
        allTens[2] = "twenty";
        allTens[3] = "thirty";
        allTens[4] = digits[4] + tenAd;
        allTens[5] = "fifty";
        allTens[6] = digits[6] + tenAd;
        allTens[7] = digits[7] + tenAd;
        allTens[8] = digits[8] + tenAd.Substring(1);
        allTens[9] = digits[9] + tenAd;

        string hundred = "hundred";                 // special word 

        if (result == false)                        // first ot check if the user has entered number (and avoid execption)
        {
            Console.WriteLine("Not a digit!");
        }
        else if ((result) & (userNumber < 10))      // SPECIAL CASES 0-9
        {
            switch (userNumber)
            {
                case 0:
                        Console.WriteLine(digits[0].Remove(1).ToUpper() + digits[0].Substring(1));
                        break; // ADding Remove(1).ToUpper() + digits[0].Substring(1) to make first letter Capital when infront
                case 1:
                        Console.WriteLine(digits[1].Remove(1).ToUpper() + digits[1].Substring(1));
                        break;
                case 2:
                        Console.WriteLine(digits[2].Remove(1).ToUpper() + digits[2].Substring(1));
                        break;
                case 3:
                        Console.WriteLine(digits[3].Remove(1).ToUpper() + digits[3].Substring(1));
                        break;
                case 4:
                        Console.WriteLine(digits[4].Remove(1).ToUpper() + digits[4].Substring(1));
                        break;
                case 5:
                        Console.WriteLine(digits[5].Remove(1).ToUpper() + digits[5].Substring(1));
                        break;
                case 6:
                        Console.WriteLine(digits[6].Remove(1).ToUpper() + digits[6].Substring(1));
                        break;
                case 7:
                        Console.WriteLine(digits[7].Remove(1).ToUpper() + digits[7].Substring(1));
                        break;
                case 8:
                        Console.WriteLine(digits[8].Remove(1).ToUpper() + digits[8].Substring(1));
                        break;
                case 9:
                        Console.WriteLine(digits[9].Remove(1).ToUpper() + digits[9].Substring(1));
                        break;
            }
        }
        else if ((result) & (userNumber >= 10) & (userNumber < 20)) // SPECIAL CASES 10-19
        {
            switch (userNumber)
	        {

                case 10:
                    Console.WriteLine(toTwenty[0].Remove(1).ToUpper() + toTwenty[0].Substring(1));
                        break;        
                case 11:
                        Console.WriteLine(toTwenty[1].Remove(1).ToUpper() + toTwenty[1].Substring(1));
                        break;     
                case 12:
                        Console.WriteLine(toTwenty[2].Remove(1).ToUpper() + toTwenty[2].Substring(1));
                        break;
                case 13:
                        Console.WriteLine(toTwenty[3].Remove(1).ToUpper() + toTwenty[3].Substring(1));
                        break;
                case 14:
                        Console.WriteLine(toTwenty[4].Remove(1).ToUpper() + toTwenty[4].Substring(1));
                        break;
                case 15:
                        Console.WriteLine(toTwenty[5].Remove(1).ToUpper() + toTwenty[5].Substring(1));
                        break;
                case 16:
                        Console.WriteLine(toTwenty[6].Remove(1).ToUpper() + toTwenty[6].Substring(1));
                        break;
                case 17:
                        Console.WriteLine(toTwenty[7].Remove(1).ToUpper() + toTwenty[7].Substring(1));
                        break;
                case 18:
                        Console.WriteLine(toTwenty[8].Remove(1).ToUpper() + toTwenty[8].Substring(1));
                        break;
                case 19:
                        Console.WriteLine(toTwenty[9].Remove(1).ToUpper() + toTwenty[9].Substring(1));
                        break;      
            }
        }
        else if ((result) & (userNumber >= 20) & (userNumber < 100))         // 20-99
        {
            int firstDIgit = userNumber / 10;     // what is first digit of the user number  - will use this to call the array members                    
            int secondDigit = userNumber % 10;    // what is second digit of the user number  - will use this to call the array members  
            
            if (secondDigit == 0)                //check for all numbers ending with 0  (20-99) SPECIAL CASES
            {
                switch (userNumber)
                {
                    case 20:
                        Console.WriteLine(allTens[2].Remove(1).ToUpper() + allTens[2].Substring(1));
                        break;
                    case 30:
                        Console.WriteLine(allTens[3].Remove(1).ToUpper() + allTens[3].Substring(1));
                        break;
                    case 40:
                        Console.WriteLine(allTens[4].Remove(1).ToUpper() + allTens[4].Substring(1));
                        break;
                    case 50:
                        Console.WriteLine(allTens[5].Remove(1).ToUpper() + allTens[5].Substring(1));
                        break;
                    case 60:
                        Console.WriteLine(allTens[6].Remove(1).ToUpper() + allTens[6].Substring(1));
                        break;
                    case 70:
                        Console.WriteLine(allTens[7].Remove(1).ToUpper() + allTens[7].Substring(1));
                        break;
                    case 80:
                        Console.WriteLine(allTens[8].Remove(1).ToUpper() + allTens[8].Substring(1));
                        break;
                    case 90:
                        Console.WriteLine(allTens[9].Remove(1).ToUpper() + allTens[9].Substring(1));
                        break;
                }
            }
            else if (secondDigit != 0)  // for ALL other number within 20-99
            {
                string tensWord = "";                                          // declaring an empty string variable
                tensWord = allTens[firstDIgit] + " " + digits[secondDigit];    // actual naming (call the array members)
                Console.WriteLine(tensWord.Remove(1).ToUpper() + tensWord.Substring(1)); 
            }
        }
        else if ((result) & (userNumber >= 100) & (userNumber < 1000))          //from this point below I am checking 100-999
        {
            int firstDIgit = userNumber / 100;              // first digit of the number
            int secondDigit = userNumber / 10 % 10;         // second digit of the number
            int thirdDigit = ((userNumber * 10) % 100) / 10;    // third digit of the number
            //Console.WriteLine(firstDIgit);    for test only
            //Console.WriteLine(secondDigit);   for test only
            //Console.WriteLine(thirdDigit);    for test only

            if ((thirdDigit == 0) && (secondDigit == 0))  //SPECIAL CASES numbers ending with 0  (100-999)
            {
                switch (userNumber)
                {
                    case 100:
                        Console.WriteLine(digits[1].Remove(1).ToUpper() + digits[1].Substring(1) + " " + hundred);
                        break;
                    case 200:
                        Console.WriteLine(digits[2].Remove(1).ToUpper() + digits[3].Substring(1) + " " + hundred);
                        break;
                    case 300:
                        Console.WriteLine(digits[3].Remove(1).ToUpper() + digits[3].Substring(1) + " " + hundred);
                        break;
                    case 400:
                        Console.WriteLine(digits[4].Remove(1).ToUpper() + digits[4].Substring(1) + " " + hundred);
                        break;
                    case 500:
                        Console.WriteLine(digits[5].Remove(1).ToUpper() + digits[5].Substring(1) + " " + hundred);
                        break;
                    case 600:
                        Console.WriteLine(digits[6].Remove(1).ToUpper() + digits[6].Substring(1) + " " + hundred);
                        break;
                    case 700:
                        Console.WriteLine(digits[7].Remove(1).ToUpper() + digits[7].Substring(1) + " " + hundred);
                        break;
                    case 800:
                        Console.WriteLine(digits[8].Remove(1).ToUpper() + digits[8].Substring(1) + " " + hundred);
                        break;
                    case 900:
                        Console.WriteLine(digits[9].Remove(1).ToUpper() + digits[9].Substring(1) + " " + hundred);
                        break;
                }
            }
            else if ((secondDigit != 0) & (secondDigit > 1) & (thirdDigit !=0) )   // all number without zero digits and second digit >=2
            {
                string tensWord = "";
                tensWord =(digits[firstDIgit]+" "+ hundred +" and "+ allTens[secondDigit] + " " + digits[thirdDigit]);
                Console.WriteLine(tensWord.Remove(1).ToUpper() + tensWord.Substring(1));
            }
            else if ((secondDigit != 0) & (secondDigit < 2) & (thirdDigit != 0))  // here is the deal - to determine the special case for 11-20
            {                                                                     // i am using the third number insted of the second
                string tensWord = "";
                tensWord = (digits[firstDIgit] + " " + hundred + " and " + toTwenty[thirdDigit] ); //key moment!! for determing which member of toTwenty using the third digit!!
                Console.WriteLine(tensWord.Remove(1).ToUpper() + tensWord.Substring(1));
            }
            else if ((secondDigit < 1) & (thirdDigit != 0))     //last special case - hundreds-within-01-09 (example: 107, 203, 409)
            {
                string tensWord = "";
                tensWord = (digits[firstDIgit] + " " + hundred + " and "  + digits[thirdDigit]);
                Console.WriteLine(tensWord.Remove(1).ToUpper() + tensWord.Substring(1));
            }
            else if ((secondDigit > 0) & (thirdDigit == 0))     //one more special case check - for numbers that ends on 0 (examples 220 , 540 , 630)
            {
                string tensWord = "";
                tensWord = (digits[firstDIgit] + " " + hundred + " and " + allTens[secondDigit]);
                Console.WriteLine(tensWord.Remove(1).ToUpper() + tensWord.Substring(1));
            }
        }
        else
        {
            Console.WriteLine("Number out of accepted range (0-999)");
            Console.Read();
        }
        // output the english pronunciation

        // and its SMILE Time for divided.zero ;)
    }
}

