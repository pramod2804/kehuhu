using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MaxConsOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    result = Math.Max(count, result);
                }
                else count = 0;
            }

            return result;

        }
    }
}
