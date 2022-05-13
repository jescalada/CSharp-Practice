using System;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Temperature on {0:dd.MM.yy} is {1}C.", DateTime.Today, 23.4);
            Console.WriteLine(
                "Temperature on {0:D} is {1}C.", DateTime.Today, 23.4);
            Console.WriteLine(
                "Temperature on {0:M} is {1}C.", DateTime.Today, 23.4);
            Console.WriteLine(
                "Temperature on {0:hh:mm} is {1}C.", DateTime.Now, 23.4); // Does not show correct time
            Console.WriteLine(
                "Temperature on {0:hh} is {1}C.", DateTime.Now, 23.4);
            string text = "interpolated strings";
            Console.WriteLine(
                $"Behold! The power of {text}! The variable {nameof(text)} is of type {text.GetType()}.");

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            // check the three variables have the same value
            // both statements output true
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine(
            $"{decimalNotation == hexadecimalNotation}");

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}