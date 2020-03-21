using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
            // For numbers which are multiples of both three and five print "FizzBuzz".

            Console.WriteLine("\n\nFizzBuzz1:\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            FizzBuzz1();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\nFizzBuzz2:\n\n");
            Console.ForegroundColor = ConsoleColor.Red;

            FizzBuzz2();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\nFizzBuzz3:\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            FizzBuzz3();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void FizzBuzz1()
        {

            bool isMultipleOfThree = false;
            bool isMultipleOfFive = false;
            string printVal = "";
            // Count from 1 to 100
            for (int i = 1; i <= 100; ++i)
            {
                if (i % 3 == 0)
                {
                    isMultipleOfThree = true;
                    printVal += "Fizz";
                }
                if (i % 5 == 0)
                {
                    isMultipleOfFive = true;
                    printVal += "Buzz";
                }

                if (printVal.Equals(""))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(printVal);
                }
                printVal = "";
            }
        }

        // Version 2: removed unnecessary booleans; cleaner ternary assignment of strings
        public static void FizzBuzz2()
        {

            string printVal = "";
            // Count from 1 to 100
            for (int i = 1; i <= 100; ++i)
            {
                if (i % 3 == 0)
                {
                    printVal += "Fizz";
                }
                if (i % 5 == 0)
                {
                    printVal += "Buzz";
                }

                printVal = printVal.Equals("") ? i.ToString() : printVal;
                Console.WriteLine(printVal);
                printVal = "";
            }
        }

        // Version 3: added defensive equals (constant first negates the risk of accidental assignment)
        public static void FizzBuzz3()
        {

            string printVal = "";
            // Count from 1 to 100
            for (int i = 1; i <= 100; ++i)
            {
                if (0 == i % 3)
                {
                    printVal += "Fizz";
                }
                if (0 == i % 5)
                {
                    printVal += "Buzz";
                }

                printVal = printVal.Equals("") ? i.ToString() : printVal;
                Console.WriteLine(printVal);
                printVal = "";
            }
        }
    }
}
