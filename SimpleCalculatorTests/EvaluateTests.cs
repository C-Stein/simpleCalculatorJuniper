using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateCanAdd()
        {
            Evaluate twoPlusThree = new Evaluate("2 + 3");
            Assert.AreEqual(5, twoPlusThree.doMath());
        }

        [TestMethod]
        public void EvaluateCanAddWithNegativeNumbers()
        {
            Evaluate twoPlusThree = new Evaluate("-2+-3");
            Assert.AreEqual(-5, twoPlusThree.doMath());
        }

        [TestMethod]
        public void EvaluateCanSubtract()
        {
            Evaluate twoPlusThree = new Evaluate("2 - 3");
            Assert.AreEqual(-1, twoPlusThree.doMath());
        }

        [TestMethod]
        public void EvaluateCanMultiply()
        {
            Evaluate twoPlusThree = new Evaluate("2 * 3");
            Assert.AreEqual(6, twoPlusThree.doMath());
        }

        [TestMethod]
        public void EvaluateCanModulus()
        {
            Evaluate twelveModThree = new Evaluate("12 % 3");
            Assert.AreEqual(0, twelveModThree.doMath());
        }
    }
}
