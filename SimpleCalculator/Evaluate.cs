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
        public Parse Expression { get; set; }



        public Evaluate(string input, Constant currentConstant)
        {
            inputString = input;
            Expression = new Parse(inputString, currentConstant);
        }

        public Evaluate(string input)
        {
            inputString = input;
            Expression = new Parse(inputString);
        }

        public string Last()
        {
            return inputString;
        }

        public int doMath()
        {
            
            Expression.setOperatorIndex();
            string mathOperation = Expression.mathOperation();
            if ( mathOperation == "+")
            {
                return Expression.firstNum() + Expression.secondNum();
            } else if ( mathOperation == "-")
            {
                return Expression.firstNum() - Expression.secondNum();
            } else if (mathOperation == "*")
            {
                return Expression.firstNum() * Expression.secondNum();
            } else if (mathOperation == "%")
            {
                return Expression.firstNum() % Expression.secondNum();
            } else if (mathOperation == "/")
            {
                return Expression.firstNum() / Expression.secondNum();
            } else
            {
                throw new ArgumentException();
            }
        }
    }
}
