using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TwoSumInputArray
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return null;

            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int x = numbers[i] + numbers[j];
                if (x < target)
                {
                    ++i;
                }
                else if (x > target)
                {
                    j--;
                }
                else
                {
                    return new int[] { i + 1, j + 1 };
                }
            }

            return null;
        }
    }
}
