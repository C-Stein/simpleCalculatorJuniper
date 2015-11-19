using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseCanFindFirstNum()
        {
            Parse twoPlusThree = new Parse("2+ 3");
            twoPlusThree.setOperatorIndex();
            Assert.AreEqual(2, twoPlusThree.firstNum());
        }

        [TestMethod]
        public void ParseCanFindSecondNum()
        {
            Parse twoPlusThree = new Parse("2 + 3");
            twoPlusThree.setOperatorIndex();
            twoPlusThree.firstNum();
            Assert.AreEqual(3, twoPlusThree.secondNum());
        }

        [TestMethod]
        public void ParseCanFindOperation()
        {
            Parse twoPlusThree = new Parse("2 + 3");
            twoPlusThree.setOperatorIndex();
            Assert.AreEqual("+", twoPlusThree.mathOperation());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseOnlyAllowsNumbersFirst()
        {
            Parse twoPlusThree = new Parse("a + 3");
            twoPlusThree.firstNum();
         }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseOnlyAllowsNumbersSecond()
        {
            Parse twoPlusThree = new Parse("2 + b");
            twoPlusThree.setOperatorIndex();
            twoPlusThree.firstNum();
            twoPlusThree.secondNum();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseOnlyAllowsSimpleExpressions()
        {
            Parse twoPlusThree = new Parse("2 - 5 + 3");
            twoPlusThree.setOperatorIndex();
            twoPlusThree.firstNum();
            twoPlusThree.secondNum();
            
        }

        //[TestMethod]
        //public void ParseGetLength()
        //{
        //    Parse twoPlusThree = new Parse("2 + 3");
        //    twoPlusThree.setOperatorIndex();
        //    Assert.AreEqual(3, twoPlusThree.getLength());
        //}
    }
}
