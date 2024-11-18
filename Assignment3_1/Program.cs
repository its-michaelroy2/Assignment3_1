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
            Console.WriteLine("Press enter to continue...Assignment 3.1.2");
            Console.ReadLine();

            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_1_2");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("2. If year is leapGiven a year as integer, write a method that checks if year is leap.Expected input and outputIfYearIsLeap(2016) → true IfYearIsLeap(2018) → false");

            Console.WriteLine("Please enter a year, and press ENTER to check whether it's a leap year.");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = IsLeapYear(year);
            Console.WriteLine($"\nIs {year} a leap year? " + isLeapYear);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...Assignment 3.1.3");
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

        static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}
