using System;
using System.Text;

namespace dojo
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            var sb = new StringBuilder(1, 8);

            if (number % 3 == 0 || number % 10 == 3 || number / 10 == 3)
            {
                sb.Append("Fizz");
            }

            if (number % 5 == 0 || number % 10 == 5 || number / 10 == 5)
            {
                sb.Append("Buzz");
            }

            if (sb.Length == 0)
            {
                sb.Append(number);
            }

            return sb.ToString();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(fb.FizzBuzz(i));
            }
            Console.ReadLine();
        }
    }
}