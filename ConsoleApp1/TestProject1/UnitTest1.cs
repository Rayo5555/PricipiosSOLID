using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FizzBuzz fb;
        public UnitTest1()
        {
            fb = new FizzBuzz();
        }

        [TestMethod]
        [DataRow (3, "fizz")]
        [DataRow(10, "buzz")]
        [DataRow(15, "fizzbuzz")]
        [DataRow(4, "4")]
        public void TestMethod1(int n, string str)
        {
            Assert.AreEqual(fb.check(n), str);
        }
    }
}
