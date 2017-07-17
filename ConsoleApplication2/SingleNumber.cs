using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SingleNumber
    {
        public int SingleNumberFunction(int[] nums)
        {

            int result = 0;
            for ( int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;

        }       
    }
}
