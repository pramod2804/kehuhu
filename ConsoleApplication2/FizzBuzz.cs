using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FizzBuzz
    {
        public IList<string> FizzBuzzStr(int n)
        {
            List<string> str = new List<string>();
            for(int i = 1; i <= n; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    str.Add("FizzBuzz");
                }
                else if ((i%3) == 0 )
                {
                    str.Add("Fizz");
                }
                else if((i % 5) == 0 )
                {
                    str.Add("Buzz");
                }                
                else
                {
                    str.Add(i.ToString());
                }

            }

            return str;
        }
    }
}
