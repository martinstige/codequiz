using codequiz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssert;

namespace qodequiz.tests
{
    [TestClass]
    public class Question1Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Question1.test(1, 2).ShouldBeEqualTo(3);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Question1.test(2, 2).ShouldBeEqualTo(12);
        }
    }
}
