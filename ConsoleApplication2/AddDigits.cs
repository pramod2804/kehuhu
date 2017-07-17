using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class AddDigits
    {
        public int AddDigitsFunction(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
                return (num - 1) % 9 + 1;
            
        }
    }
}
