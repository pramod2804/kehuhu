using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    //Given an array of ints, write a C# method to total all the values that are even numbers.
    class EvenNumberTotal
    {
        public int EvenNumbersTotal( int[] arr)
        {
            int total = 0;
            for ( int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    total += arr[i];
                }
            }
            return total;
        }
    }
}
