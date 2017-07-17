using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MinMoveArray
    {
        public int MinMoves(int[] nums)
        {
            int sum = 0, min = Int32.MaxValue;
            for (int i = 0; i < nums.Length; sum += nums[i++]) min = (nums[i] < min) ? nums[i] : min;
            return sum - nums.Length * min;

        }
    }
}
