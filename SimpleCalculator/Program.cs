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
            Parse twoPlusTwo = new Parse("2+2");
            twoPlusTwo.firstNum();
            twoPlusTwo.secondNum();
        }
    }
}
