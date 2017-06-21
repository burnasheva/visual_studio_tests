using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VSTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestPlus()
        {
            Assert.AreEqual(Calculator.Plus(1, 5), 6, "Wrong result");
        }
    }
}
