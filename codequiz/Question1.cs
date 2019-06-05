using System;

namespace codequiz
{
    public class Question1 : TestBase
    {
        
        public override void RunTest()
        {
            PrintTestName(this);

            Console.WriteLine(test(1, 2) == 3);
            Console.WriteLine(test(10, 2) == 12);
            Console.WriteLine(test(5, 0) == 5);
            Console.WriteLine(test(2, 2) == 12);
            Console.WriteLine(test(0, 0) == 0);
        }

        public static int test(int x, int y)
        {
            return (x == y ? 3 * (x + y) : x + y);
            // Implement the method 'test' to compute the sum of two given integer values. 
            // If the two values are the same, then return triple their sum.
        }

    }
}
