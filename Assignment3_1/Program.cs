using System.Text;

namespace Assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_1_1");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("1. Write a method that returns a string of even numbers greater than 0 and less than 100. Use the stringbuilder class.\n");

            string evenNumbers = GetEvenNumbers();
            Console.WriteLine("Even numbers from 1-100");
            Console.WriteLine(evenNumbers);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...Assignment 3.2, etc");
            Console.ReadLine();
        }

        static string GetEvenNumbers()
        {
            StringBuilder evenNumbers = new StringBuilder();
            for (int i = 2; i <= 100; i += 2)
            {
                evenNumbers.Append(i);
                if (i <= 98)
                {
                    evenNumbers.Append(", ");
                }
            }
            return evenNumbers.ToString();
        }
    }
}
