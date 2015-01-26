using System;

/*
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement.
 * 
 *      program	user
 * ------------------------------
 Please choose a type:      choice6	
         1 --> int	
         2 --> double	        3
         3 --> string	
 * ------------------------------
    Please enter a string:	hello
 * ------------------------------
             hello*
 */
class PlayIntDoubleString
  {
      static void Main()
      {
          Console.WriteLine("1 ----> int \n"+
                            "2 ----> double \n"+
                            "3 ----> string");
          int userChoice = int.Parse(Console.ReadLine());               // the selector counter
          
          switch (userChoice)
          {
              case 1:                                                   // after user selection we describe what to happen for each case
                  Console.WriteLine("Please enter int:");               
                  int integerChoice = int.Parse(Console.ReadLine());    
                  integerChoice = integerChoice + 1;                    // adding the new value (as the homeworks whants) to the variable
                  Console.WriteLine(integerChoice);
                  break;                                                //dont forget to break after all is done - else it will crush

              case 2:
                  Console.WriteLine("Please enter a double:");
                  double doubleChoice = double.Parse(Console.ReadLine());
                  doubleChoice = doubleChoice + 1;
                  Console.WriteLine(doubleChoice);
                  break;

              case 3:
                  Console.WriteLine("Please enter a string:");
                  string stringChoice = Console.ReadLine();
                  stringChoice = stringChoice + "*";
                  Console.WriteLine(stringChoice);
                  break;

              default:
                  Console.WriteLine("Invalid choice");
                  break;
          }
      }
  }

