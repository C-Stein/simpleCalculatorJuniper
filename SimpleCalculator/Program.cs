using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Constant currentConstant = new Constant();
            Evaluate expression; 
            

            while (true)
            {
                Console.Write("[{0}]> ", count);
                string input = Console.ReadLine();
                expression = new Evaluate(input, currentConstant);
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
                }
                else if (input.IndexOf("=")> -1)
                {
                    //set variable

                    Parse addConstant = new Parse(input, currentConstant);
                    addConstant.setOperatorIndex();
                    currentConstant.addConst(addConstant.StringFirst(), addConstant.secondNum());
                    // = saved 'x' as '3'
                    Console.WriteLine("= saved '" + addConstant.StringFirst() + "' as '" + addConstant.secondNum() + "'");
                    Console.WriteLine(currentConstant.getNum("a"));

                }
                else
                {
                    int answer = expression.doMath();
                    Console.WriteLine("   = {0}", answer);
                    count++;

                }
            }
        }
    }
}
