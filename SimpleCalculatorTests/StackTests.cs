using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackEnsureICanCreateInstance()
        {
            Evaluate oldStack = new Evaluate("2 * 8");
            Stack newStack = new Stack(oldStack);
            Assert.IsNotNull(newStack);
        }

        [TestMethod]
        public void StackCanReturnLast()
        {
            Evaluate oldStack = new Evaluate("2 * 8");
            Evaluate newStack = new Evaluate("2+5");
            Stack myStack = new Stack(newStack);
            Assert.AreEqual("2+5", myStack.Lastq());
        }

        [TestMethod]
        public void StackCanReturnLastQ()
        {
            Evaluate expression = new Evaluate("2 * 8");
            Stack myStack = new Stack(expression);
            Assert.AreEqual(16, myStack.Last());
        }
    }
}
