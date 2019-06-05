using System;
using System.Collections.Generic;
using System.Text;

namespace codequiz
{
    class Question2 : TestBase
    {
        public override void RunTest()
        {
            PrintTestName(this);

            Console.WriteLine(GetLowest(new[] { 1, 2, 3, 4, 5, 6 }) == 1);
            Console.WriteLine(GetLowest(new[] { -1, 34, 98, 0, 1, -9, -10 }) == -10);
            Console.WriteLine(GetLowest(new int [0]) == -1);
            Console.WriteLine(GetLowest(null) == -1);
        }

        private static int GetLowest(int[] numbers)
        {
            // Implement the method so it returns the lowest number
            return -1;
        }
    }
}
