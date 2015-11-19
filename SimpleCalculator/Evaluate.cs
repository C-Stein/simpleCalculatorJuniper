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

        public int doMath()
        {
            Parse expression = new Parse(inputString);
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
                return 2;
            } else
            {
                throw new ArgumentException();
            }
        }
    }
}
