using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! \n" +
                "I'm HAM (Happily Automated Mathematician). \n " +
                "How may I be of assistance today?: ");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            bool runMenu = true;
            do
            {
                Console.Clear();
                Console.Write("--------------Calculator Menu--------------\n" +
                    "Enter 1 for Addition. \n" +
                    "Enter 2 for Subtracion.\n" +
                    "Enter 3 for Multiplication\n" +
                    "Enter 4 for Division.\n" +
                    "Enter Quit to exit.\n" +
                    "Selection:");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                       Addition();
                        break;

                    case "2":
                        //Subtraction();

                        break;

                    case "3":
                        //Multiplication();
                        break;

                    case "4":
                        //Division();
                        break;
                   
                    case "Quit":
                        runMenu = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid input. Please try again.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
            while (runMenu);




        }

         static int TextToNumber(string textNumber)
         {
             int number = 0;

             int.TryParse(textNumber, out number);

             return number;
         }
        static int Addition()
        {
            int numberOne;
            int numberTwo;
            int additionResult;

            Console.WriteLine("Please enter a number: ");
            numberOne = TextToNumber(Console.ReadLine());


            Console.WriteLine("Please enter the number that you wish to add: ");
            numberTwo = TextToNumber(Console.ReadLine());

            additionResult = numberOne + numberTwo;

            Console.Write("That adds up to:" + additionResult);
            
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            
            return additionResult;
        }


       /* static int Subtraction()
        {

        } 
        static int Multiplication()
        {

        } 
        static float Division()
        {

        }*/
    }
}
