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
            Console.WriteLine("\nPress enter to continue...Assignment 3.1.2");
            Console.ReadLine();

            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to continue to Assignment 3.1.2? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response == "yes" || response == "y")
                {
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("         Assignment3_1_2");
                    Console.WriteLine("=================================\n\n");
                    Console.WriteLine("2. If year is leapGiven a year as integer, write a method that checks if year is leap.Expected input and outputIfYearIsLeap(2016) → true IfYearIsLeap(2018) → false");

                    Console.WriteLine("Please enter a year, and press ENTER to check whether it's a leap year.");
                    int year = Convert.ToInt32(Console.ReadLine());
                    bool isLeapYear = IsLeapYear(year);
                    Console.WriteLine($"\nIs {year} a leap year? " + isLeapYear);

                    Console.WriteLine();
                    Console.WriteLine("Type yes to continue to Assignment 3.1.3");
                    Console.ReadLine();
                    Console.WriteLine("\nDo you want to continue to the next question? (yes/no)");
                    response = Console.ReadLine().ToLower();

                    if (response == "yes" || response == "y")
                    {
                        CountSpacesInString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for using the program. Goodbye!");
                        break;
                    }
                }
                else if (response == "no" || response == "n")
                {
                    Console.WriteLine("\nThank you for using the program. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    Console.WriteLine("Press Enter to try again...");
                    Console.ReadLine();
                }
            }
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

        static void CountSpacesInString()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_1_3");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("3. Write a method that counts the number of spaces in a string. input = 'This is a test string' ouput = constians 4 spaces.");

            Console.WriteLine("\nPlease enter a string and Press ENTER.");
            string input = Console.ReadLine();

            int spaceCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine($"The string '{input}' contains {spaceCount} spaces.");

            Console.WriteLine("\nType yes to continue to Assignment 3.1.4");
            string userResponse = Console.ReadLine().ToLower();
                if ( userResponse == "yes" || userResponse == "y")
                {
                    DetermineQuadrant();
                }
                else
                {
                    Console.WriteLine("\nThank you for using the program. Goodbye!");
                }
        }

        static void DetermineQuadrant()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_1_4");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("4. Determine the quadrant of a coordinate point in an XY coordinate system.");

            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string quadrant;

            if (x > 0 && y > 0)
                quadrant = "First";
            else if (x < 0 && y > 0)
                quadrant = "Second";
            else if (x < 0 && y < 0)
                quadrant = "Third";
            else if (x > 0 && y < 0)
                quadrant = "Fourth";
            else if (x == 0 && y == 0)
                quadrant = "Origin";
            else if (x == 0)
                quadrant = "Y-axis";
            else
                quadrant = "X-axis";

            Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in the {quadrant} {(quadrant == "Origin" || quadrant.EndsWith("axis") ? "." : "quadrant.")}");

            Console.WriteLine("\nType yes to continue to Assignment 3.1.5");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "yes" || userResponse == "y")
            {
                ChangeConsecutiveOnes();
            }
            else
            {
                Console.WriteLine("\nThank you for using the program. Goodbye!");
            }
        }

        static void ChangeConsecutiveOnes()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_1_5");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("5. Find the first occurrence of 2 consecutive 1s and change their value to 0.");

            Console.WriteLine("\nEnter the array elements separated by commas (e.g., 0,2,1,1,9,1,1):");
            string input = Console.ReadLine();

            // Parse the input string into an integer array
            // somewhat like JS/Py
            int[] array = input.Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("\nUser array: " + string.Join(", ", array));

            // Find and change consecutive ones
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 1 && array[i + 1] == 1)
                {
                    array[i] = 0;
                    array[i + 1] = 0;
                    break; 
                    // Stop after changing the first occurrence
                }
            }

            Console.WriteLine("New array: " + string.Join(", ", array));
        }
    }
}
