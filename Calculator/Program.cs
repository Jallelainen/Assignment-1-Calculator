using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm HAM (Happily Automated Mathematician). " +
                "How may I be of service?");

            int index = 0;

            List<string> menuItem = new List<string>()
            {
                "Addition",
                "Subtraction",
                "Multiplication",
                "Division",
                "Exit Program"
            };

            Console.CursorVisible = false;
            while (true)
            {
                for (int i = 0; i < menuItem.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        
                        Console.WriteLine(menuItem[i]);
                    } 
                    else
                    {
                        Console.WriteLine(menuItem[i]);
                    }

                    Console.ResetColor();

                }
                
                ConsoleKeyInfo ckey = Console.ReadKey();

                if(ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == menuItem.Count - 1) 
                    {
                        index = 0; 
                    }
                    else 
                    {
                        index++;
                    } 
                }
                else if(ckey.Key == ConsoleKey.UpArrow)
                {
                    if (index <= 0)
                    {
                        index = menuItem.Count - 1;
                    } 
                    else
                    {
                        index--;
                    }
                }

                Console.Clear();
            }

        }
    }
}
