using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 --DONE
            int[] numbers = new int[] { 73, 14, 23, 87, 78, 31, 39, 12, 28, 8 };
            /* Create two Lists of type int.--DONE
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List --DONE
             */

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("EVENS");
            Console.WriteLine("-----");
            Console.WriteLine("-----");
                        
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(""); 
            Console.WriteLine("ODDS");
            Console.WriteLine("----");
            Console.WriteLine("----");
            

            for(int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
