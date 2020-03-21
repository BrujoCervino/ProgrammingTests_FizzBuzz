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

            Console.WriteLine("FizzBuzz:\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            FizzBuzz();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void FizzBuzz()
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
