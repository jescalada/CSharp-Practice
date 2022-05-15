using System;
using static System.Console;
using static System.Convert;

namespace Conversion
{
  class Program
  {
    static void Main(string[] args)
    {
      double g = 9.8;
      int h = ToInt32(g);
      WriteLine($"g is {g} and h is {h}");
  
      // Rounding in C# is Banker's Rounding (reduces bias by alternating roundup/rounddown)
      double[] doubles = new[]
        { 9.5, 10.5, 11.5, 12.5 };

      foreach (double n in doubles)
      {
        WriteLine($"ToInt({n}) is {ToInt32(n)}");
      }

      // You can override default rounding rules:
      foreach (double n in doubles)
      {
        WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)); // This is school rounding
      }

      int age = int.Parse("23");
      DateTime birthday = DateTime.Parse("15 January 1999 7:00 AM");

      WriteLine($"I was born {age} years ago.");
      WriteLine($"My birthday is {birthday}.");
      WriteLine($"My birthday is {birthday:D}.");

      // TryParse prevents errors:
      Write("How many eggs are there? ");
      int count;
      string input = ReadLine();

      if (int.TryParse(input, out count))
      {
        WriteLine($"There are {count} eggs.");
      }
      else
      {
        WriteLine("Couldn't parse the input.");
      }
    }
  }
}
