using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = (args.Length == 0) ? new int[] { 3, 5, 7, 11, 13, 17 } : args.Select(p => int.Parse(p));
            Console.Write("Enter a maximum value for FizzBuzz: ");
            int maxValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxValue; i++)
            {
                string output = "";
                if (i % 3 == 0 && rules.Contains(3))
                {
                    output += "Fizz";
                }
                if (i % 5 == 0 && rules.Contains(5))
                {
                    output += "Buzz";
                }
                if (i % 7 == 0 && rules.Contains(7))
                {
                    output += "Bang";
                }
                if (i % 11 == 0 && rules.Contains(11))
                {
                    output = "Bong";
                }
                if (output == "")
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
        }
    }
}
