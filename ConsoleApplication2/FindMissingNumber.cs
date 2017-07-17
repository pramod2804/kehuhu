using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FindMissingNumber
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> ret = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                {
                    nums[val] = -nums[val];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    ret.Add(i + 1);
                }
            }
            return ret;

        }
    }
}
