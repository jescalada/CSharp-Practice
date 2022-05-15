using System;
using static System.Console;

namespace Functions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table.");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                    $"{row} x {number} = {row * number}");
            }
            WriteLine();
        }
    
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(
                    ReadLine(), out byte number); // number will only have a value if there is no exception (it's an output)

                if (isNumber)
                {
                    TimesTable(number); // Notice how out allows us to use that number later on
                }
                else
                {
                    WriteLine($"Invalid number!");
                }
            } while (isNumber);
        }

        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd"
                    };
                    return $"{number}{suffix}";
            }
        }

        static void Main(string[] args)
        {
            RunTimesTable();
            CardinalToOrdinal(12);
            CardinalToOrdinal(25);
        }
    }
}
