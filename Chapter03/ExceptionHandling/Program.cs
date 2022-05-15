using System;
using static System.Console;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
            string input = ReadLine();
            try {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch(FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch(OverflowException)
            {
                WriteLine("Your age is a valid number but it's too big or too small.");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");
            try 
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but the exception was caught.");
            }
            
        }
    }
}
