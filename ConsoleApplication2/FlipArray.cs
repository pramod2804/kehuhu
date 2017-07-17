using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FlipArray
    {       
        public static int FindComplement(int num)
        {
            var result = Convert.ToString(num, 2);
            char[] chrArry = result.ToCharArray();
            for (int i = 0; i < chrArry.Length; i++)
            {
                if (chrArry[i].Equals('1'))
                {
                    chrArry[i] = '0';
                }
                else
                {
                    chrArry[i] = '1';
                }
            }
            string returnArr = new string(chrArry);
            int convNumber = Convert.ToInt32(returnArr, 2);                       
            return convNumber;
        }
    }
}
