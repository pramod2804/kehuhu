    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int[] newArr = new int[nums.Length];
            int j = k;
            int m = 0;
            for ( int i=0; i< nums.Length; i++)
            {
                if ( i >= (nums.Length - k))
                {
                    newArr[m] = nums[i];
                    m++;                    
                }
                else if ( j < nums.Length)
                {
                    newArr[j] = nums[i];
                    j++;                    
                }                
            }
            nums = newArr;
        }
    }
}
