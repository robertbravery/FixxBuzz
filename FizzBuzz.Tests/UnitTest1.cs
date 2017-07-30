using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LinqLoopTest()
        {
            var duration = LinqLoop.Loop(10000);

            Assert.Fail("Test are failing so far. Make tests pass");
        }
    }
}
