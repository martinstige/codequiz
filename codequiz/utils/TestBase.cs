using System;
using System.Collections.Generic;
using System.Text;

namespace codequiz
{
    public abstract class TestBase
    {
        public abstract void RunTest();

        protected void PrintTestName(object caller)
        {
            Console.WriteLine();
            Console.WriteLine(caller.GetType().Name);
            Console.WriteLine("-------------------");    
        }
    }


}
