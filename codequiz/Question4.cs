using System;
using System.Collections.Generic;
using System.Text;

namespace codequiz
{
    public class Question4 : TestBase
    {
        public override void RunTest()
        {
            PrintTestName(this);
            //Write code that finds the sum of first n natural numbers using recursion.
            Console.WriteLine(SumOfFirst(10) == 55);
            Console.WriteLine(SumOfFirst(0) == 0);
        }
        private static int SumOfFirst(int n)
        {
            if (n == 0)
                return 0;
            return n + SumOfFirst(n - 1);
        }
    }
}
