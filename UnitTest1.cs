using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArithmeticMean()
        {
            int a = 3;
            int b = 27;
            double res = Lab1.Program.ArithmeticMean(a, b);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void GeometricMean()
        {
            int a = 3;
            int b = 27;
            double res = Lab1.Program.GeometricMean(a, b);
            Assert.AreEqual(9, res);
        }
    }
}
