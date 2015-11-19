using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public string inputString;

        public Evaluate(string input)
        {
            inputString = input;
        }

        public string Last()
        {
            return inputString;
        }

        public int doMath()
        {
            Parse expression = new Parse(inputString);
            expression.setOperatorIndex();
            string mathOperation = expression.mathOperation();
            if ( mathOperation == "+")
            {
                return expression.firstNum() + expression.secondNum();
            } else if ( mathOperation == "-")
            {
                return expression.firstNum() - expression.secondNum();
            } else if (mathOperation == "*")
            {
                return expression.firstNum() * expression.secondNum();
            } else if (mathOperation == "%")
            {
                return expression.firstNum() % expression.secondNum();
            } else if (mathOperation == "/")
            {
                return expression.firstNum() / expression.secondNum();
            } else
            {
                throw new ArgumentException();
            }
        }
    }
}
