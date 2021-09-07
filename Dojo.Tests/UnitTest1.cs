using System;
using System.Text;
using Xunit;

namespace Dojo.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "FizzBuzz")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        public void Test1(int number, string expectedResult)
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.FizzBuzz(number);

            Assert.Equal(expectedResult, result);
        }

        public class FizzBuzzer
        {
            public string FizzBuzz(int number)
            {
                var sb = new StringBuilder(1, 8);

                if (number % 3 == 0)
                {
                    sb.Append("Fizz");
                }

                if (number % 5 == 0)
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
    }
}
