using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void LinqLoopTest()
        {
            var expected = 10;
            var duration = LinqLoop.Loop(1000);

            Assert.IsTrue(expected>duration);
        }

        [TestMethod]
        public void NormalLoopTest()
        {
            var expected = 10;
            var duration = NormalLoop.Loop(1000);

            Assert.IsTrue(expected > duration);
        }

        [TestMethod]
        public void ForLoopTest()
        {
            var expected = 10;
            var duration = ForLoop.Loop(1000);

            Assert.IsTrue(expected > duration);
        }
    }
}
