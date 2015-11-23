﻿using System;
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

            while (true)
            {
                Console.Write("[{0}]", count);
                string input = Console.ReadLine();
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
                }
                else if (input.IndexOf("=")> -1)
                {
                    //set variable
                    Parse addConstant = new Parse(input);
                    addConstant.setOperatorIndex();
                    addConstant.addConst(addConstant.StringFirst(), addConstant.secondNum());
                    // = saved 'x' as '3'
                    Console.WriteLine("= saved '" + addConstant.StringFirst() + "' as '" + addConstant.secondNum() + "'");

                }
                else
                {
                    Evaluate expression = new Evaluate(input);
                    int answer = expression.doMath();
                    Console.WriteLine(answer);
                    count++;

                }
            }
        }
    }
}
