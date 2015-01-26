using System;

/*
 * Write a program that asks for a digit (0-9), 
 * and depending on the input, shows the digit as a word (in English).
 * Print “not a digit” in case of invalid input.Use a switch statement.
        Examples:

        d	    result
        2	    two
        1	    one
        0	    zero
        5	    five
      -0.1	    not a digit
        hi	    not a digit
        9	    nine
        10	    not a digit
 */
  class DigitWord
  {
      static void Main()
      {
          string userChoice = Console.ReadLine();                  // instead of int we are accepting strings from users

          int userNumber;                                          // this variable will be used after the string is confirmed and converted to int

          bool result = int.TryParse(userChoice, out userNumber);  // TryParse for the string.. if it is number it will jump to switch-case
                                                                   // if result is false - the program will avoid crashing and shows up message 
          if (result == false)
          {
              Console.WriteLine("Not a digit");
          }
          else if (result == true)
          {
              switch (userNumber)
              {
                  case 0:                                          // after each case we should use break; to escape from the loop
                      {
                          Console.WriteLine("Zero");
                          break;
                      }
                  case 1:
                      {
                          Console.WriteLine("One");
                          break;
                      }
                  case 2:
                      {
                          Console.WriteLine("Two");
                          break;
                      }
                  case 3:
                      {
                          Console.WriteLine("Three");
                          break;
                      }
                  case 4:
                      {
                          Console.WriteLine("Four");
                          break;
                      }
                  case 5:
                      {
                          Console.WriteLine("Five");
                          break;
                      }
                  case 6:
                      {
                          Console.WriteLine("Six");
                          break;
                      }
                  case 7:
                      {
                          Console.WriteLine("Seven");
                          break;
                      }
                  case 8:
                      {
                          Console.WriteLine("Eight");
                          break;
                      }
                  case 9:
                      {
                          Console.WriteLine("Nine");
                          break;
                      }
                  default:                                      //every number different from the digits will end here
                      {
                          Console.WriteLine("Not a digit");
                          break;
                      }
              }
          }
          


      }
  }

