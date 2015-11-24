using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string inputString;
        public Evaluate expression;
        public string lastq;
        public int last;
        public Constant CurrentConstant { get; set; }



        public Stack()
        {

        }

        public Stack(Evaluate input)
        {
            expression = input;
        }

        public string Lastq()
        {
            lastq = expression.Last();
            return lastq;
        }

        public int Last()
        {
            last = expression.doMath();
            return last;
        }

        public void addConst(string letter, int num)
        {
            CurrentConstant.addConst(letter, num);
        }


    }
}
