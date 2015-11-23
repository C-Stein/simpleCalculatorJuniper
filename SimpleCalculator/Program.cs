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

            while (true)
            {
                Console.Write("[{0}]", count);
                string input = Console.ReadLine();
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
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
