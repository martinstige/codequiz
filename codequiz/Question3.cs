using System;
using System.Collections.Generic;
using System.Text;

namespace codequiz
{
    public class Question3 : TestBase
    {
        public override void RunTest()
        {
            PrintTestName(this);

            // Write a method that converts from Fahrenheit to Celcius

            Console.WriteLine(convert(30) == 86);
            Console.WriteLine(convert(0) == 32);
            Console.WriteLine(convert(100) == 212);
            Console.WriteLine(convert(-10) == 14);
        }
        private static int convert(int fahrenheit)
        {
            // I believe it should be from Celcius to Fahrenheit.
            return fahrenheit * 9 / 5 + 32;
        }
    }
}
