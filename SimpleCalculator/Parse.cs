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


        public Parse (string input)
        {
            inputString = input;
            string[] pieces = inputString.Split(' ');

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
            else
            {
                throw new ArgumentException();
            }
        }

        public int firstNum()
        {
            
            bool parsedFirst = false;

            stringFirst = inputString.Substring(0, operatorIndex);
            parsedFirst = int.TryParse(stringFirst, out first);
            if (parsedFirst)
            {
                return first;
            } else
            {
                throw new ArgumentException();
            }
        }

        public int secondNum()
        {
            string stringSecond;
            bool parsedSecond = false;

            stringSecond = inputString.Substring(operatorIndex + 1, (inputString.Length - stringFirst.Length -1));
            parsedSecond = int.TryParse(stringSecond, out second);
            if (parsedSecond)
            {
                return second;
            }
            else
            {
                throw new ArgumentException();
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
