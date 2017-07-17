using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 5, 4, 3, 2, 1 };
            EvenNumberTotal kb = new EvenNumberTotal();            
            Console.WriteLine( kb.EvenNumbersTotal(nums1).ToString());
        }

    }
}
