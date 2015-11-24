using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public string inputString;
        public int first;
        public int second;
        public string operation;
        int operatorIndex;
        public string stringFirst;
        Constant currentConstant;


        public Parse (string input, string letter, int num)
        {
            inputString = input;
            string[] pieces = inputString.Split(' ');
            currentConstant.addConst(letter, num);

        }
        public Parse(string input)
        {
            inputString = input;
            string[] pieces = inputString.Split(' ');
        }


        public Parse(string input, Constant thisConstant)
        {
            inputString = input;
            string[] pieces = inputString.Split(' ');
            currentConstant = thisConstant;

        }

        public void addConst(string letter, int num)
        {
            currentConstant.addConst(letter, num);
        }

        public void setOperatorIndex()
        {
            if (inputString.IndexOf("+") > 0)
            {
                operatorIndex = inputString.IndexOf("+");
                operation = "+";
            }
            else if (inputString.IndexOf("-") > 0)
            {
                operatorIndex = inputString.IndexOf("-");
                operation = "-";
            }
            else if (inputString.IndexOf("*") > 0)
            {
                operatorIndex = inputString.IndexOf("*");
                operation = "*";
            }
            else if (inputString.IndexOf("/") > 0)
            {
                operatorIndex = inputString.IndexOf("/");
                operation = "/";
            }
            else if (inputString.IndexOf("%") > 0)
            {
                operatorIndex = inputString.IndexOf("%");
                operation = "%";
            }
            else if (inputString.IndexOf("=") > 0)
            {
                operatorIndex = inputString.IndexOf("=");
                operation = "=";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int firstNum()
        {
            
            bool parsedFirst = false;

            stringFirst = inputString.Substring(0, operatorIndex);
            string stringFirstNoSpace = stringFirst.Replace(" ", String.Empty);
            parsedFirst = int.TryParse(stringFirst, out first);
            if (parsedFirst)
            {
                return first;
            }
            else
            {
                try
                {
                    return currentConstant.getNum(stringFirstNoSpace);
                }
                catch
                {
                    throw new ArgumentException("That's not a number or a valid variable before the operator");
                }
            }
        }

        public string StringFirst()
        {
            stringFirst = inputString.Substring(0, operatorIndex);
            return stringFirst;
        }

        public string StringSecond()
        {
            return inputString.Substring(operatorIndex + 1, (inputString.Length - stringFirst.Length - 1));
        }

        public int secondNum()
        {
            string stringSecond;
            bool parsedSecond = false;

            stringSecond = inputString.Substring(operatorIndex + 1, (inputString.Length - stringFirst.Length -1));
            string stringSecondNoSpace = stringSecond.Replace(" ", String.Empty);
            parsedSecond = int.TryParse(stringSecond, out second);
            if (parsedSecond)
            {
                return second;
            }
            else
            {
                try {
                    return currentConstant.getNum(stringSecondNoSpace);
                } catch
                {
                    throw new ArgumentException("That's not a number or a valid variable after the operator");
                }
                
            }

        }

        public string mathOperation()
        {

            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
            {
                return operation;
            } else
            {
                throw new ArgumentException();
            }
        }
    }
}
