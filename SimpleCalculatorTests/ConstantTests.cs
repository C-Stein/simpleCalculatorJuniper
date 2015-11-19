using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ConstantCanCreateInstance()
        {
            Constant myConstant = new Constant();
            Assert.IsNotNull(myConstant);
        }

        [TestMethod]
        public void ConstantCanAddConstantToList()
        {
            Constant myConstant = new Constant();
            myConstant.addConst("a", 5);
            Assert.AreEqual(5, myConstant.getNum("a"));
        }

        public void ConstantCanAddMultipleConstantsToList()
        {
            Constant myConstant = new Constant();
            myConstant.addConst("a", 5);
            myConstant.addConst("b", 8);
            Assert.AreEqual(5, myConstant.getNum("a"));
            Assert.AreEqual(8, myConstant.getNum("b"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstantCanNotAddSameLetterTwice()
        {
            Constant myConstant = new Constant();
            myConstant.addConst("a", 5);
            myConstant.addConst("a", 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstantCannotReturnNonexistantNum()
        {
            Constant myConstant = new Constant();
            myConstant.addConst("a", 5);
            myConstant.getNum("b");
        }

        [TestMethod]
        public void ConstantCanAdd()
        {
            Evaluate twoPlusThree = new Evaluate("a + 3");
            Constant newConstant = new Constant();
            newConstant.addConst("a", 2);
            Assert.AreEqual(5, twoPlusThree.doMath());
        }
    }
}
