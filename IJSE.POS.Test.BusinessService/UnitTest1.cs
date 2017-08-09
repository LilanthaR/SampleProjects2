using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading;

namespace IJSE.POS.Test.BusinessService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 10;

            int actual = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expected = 10;

            int actual = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int expected = 10;

            int actual = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPerformTime()
        {
            //using System.Threading;
            DateTime startTime = DateTime.Now;           

            Thread.Sleep(300);  // or call the function need to Test
            DateTime endTime = DateTime.Now;

            int expected = 100;

            int actual = endTime.Subtract(startTime).Milliseconds;

            if ( actual < expected)
            {
                Assert.AreEqual(true, true);
            }
            else
            {
                Assert.Fail();
            }
            
        }
    }
}
