using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RelativeRanks
    {
        public String[] findRelativeRanks(int[] nums)
        {
            int[] index = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                index[i] = i;
            }

            Array.Sort(index, (a, b) => (nums[b] - nums[a]));
            

            String[] result = new String[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    result[index[i]] = "Gold Medal";
                }
                else if (i == 1)
                {
                    result[index[i]] = "Silver Medal";
                }
                else if (i == 2)
                {
                    result[index[i]] = "Bronze Medal";
                }
                else
                {
                    result[index[i]] = (i + 1) + "";
                }
            }

            return result;
        }
    }
}
