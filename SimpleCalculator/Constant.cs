using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constant
    {
        public Dictionary<string, int> constList = new Dictionary<string, int>();
        
        public void addConst(string letter, int number)
        {
            letter = letter.ToLower();

            if (constList.ContainsKey(letter))
            {
                throw new ArgumentException("Sorry! That Letter is already in use");
            }
            else
            {
                constList.Add(letter, number);
            }
        }

        public int getNum(string letter)
        {
            letter = letter.ToLower();
            int answer;
            if (constList.TryGetValue(letter, out answer))
            {
                return answer;
            } else
            {
                throw new ArgumentException("There isn't a number associated with that letter yet.");
            }
        }
    }
}
