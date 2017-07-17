using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class StudentAbsent
    {
        public bool CheckRecord(string s)
        {
            int aCount = 0 ;
            int lCount = 0 ;
            char[] chArr = s.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == 'A' || chArr[i] == 'a')
                    aCount++;
                else if ( i <= chArr.Length - 3 && chArr[i] == 'L' && chArr[i+1] == 'L' && chArr[i+2] == 'L')
                {
                    lCount++;
                }  
            }
            if (aCount > 1 || lCount >0 )
            {
                return false;
            }

            return true;   
        }

    }
}
