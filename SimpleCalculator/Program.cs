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
            Parse aplus3 = new Parse("3 + a");
            aplus3.addConst("a", 5);
            aplus3.setOperatorIndex();
            aplus3.StringSecond();
        }
    }
}
