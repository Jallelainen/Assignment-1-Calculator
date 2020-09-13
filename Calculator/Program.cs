using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome!-----------------\n" +
                "I'm HAM (Happily Automated Mathematician). \n" +
                "How may I be of assistance today?");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            bool runMenu = true;
            do
            {
                Console.Clear();
                Console.Write("------Calculator Menu------\n" +
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
                        Subtraction();
                        break;

                    case "3":
                        Multiplication();
                        break;

                    case "4":
                        Division();
                        break;

                    case "quit":
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

         static double TextToNumber(string textNumber)
         {
            double number = 0.0;

            double.TryParse(textNumber, out number);

            return number;
         }

        static void Addition()
        {
            double numberOne;
            double numberTwo;
            double additionResult;

                Console.Clear();
                Console.WriteLine("--------Addition--------");
                PleaseEnterNum();

                    numberOne = TextToNumber(Console.ReadLine());

                    Console.WriteLine("Please enter the number that you wish to add: ");
                    numberTwo = TextToNumber(Console.ReadLine());

                additionResult = numberOne + numberTwo;

            Console.Write("That adds up to: " + additionResult);
          
            BackToMainMenu();

        }

         static void Subtraction()
         {
            double numberOne;
            double numberTwo;
            double subtractionResult;

                Console.Clear();
                Console.WriteLine("------Subtraction------");
                PleaseEnterNum();
           
                    numberOne = TextToNumber(Console.ReadLine());

                    Console.WriteLine("Please enter the number that you wish to subtract: ");
                    numberTwo = TextToNumber(Console.ReadLine());

                subtractionResult = numberOne - numberTwo;

            Console.Write("That subtracts to: " + subtractionResult);
            
            BackToMainMenu();

        } 

         static void Multiplication()
         {
            double numberOne;
            double numberTwo;
            double multiplicationResult;

                Console.Clear();
                Console.WriteLine("--------Multiplication--------");
                PleaseEnterNum();
            
                    numberOne = TextToNumber(Console.ReadLine());

                    Console.WriteLine("Please enter the number that you wish to multiply with: ");
                    numberTwo = TextToNumber(Console.ReadLine());

                multiplicationResult = numberOne * numberTwo;

            Console.Write("That multiplies to: " + multiplicationResult);
            
            BackToMainMenu();

        } 

         static void Division()
         {
            double numberOne;
            double numberTwo;
            double divisionResult;

            Console.Clear();
            Console.WriteLine("--------DIVISION--------");
            PleaseEnterNum();
            numberOne = TextToNumber(Console.ReadLine());

                Console.WriteLine("Please enter the number that you wish to divide by: ");
                numberTwo = TextToNumber(Console.ReadLine());

                    if (numberTwo == 0.0 )
                    {
                        Console.WriteLine("I'm sorry, you can not divide by zero. Please try another number:");
                        numberTwo = TextToNumber(Console.ReadLine());
                    }

            divisionResult = numberOne / numberTwo;

            Console.Write("That divides to: " + divisionResult);
            BackToMainMenu();

         }

        static void PleaseEnterNum()
        {
            Console.WriteLine("Please enter a number: ");
        }

        static void BackToMainMenu()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
