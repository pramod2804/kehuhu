using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FindTheDiff
    {
        public char FindTheDifference(string s, string t)
        {

            char[] chrAryt = t.ToCharArray();            
            for ( int i =0; i < t.Length; i ++ )
            {
                if (s.Contains(chrAryt[i]))
                {
                    continue;
                }
                else
                    return chrAryt[i];
            }

            return 'c';
        }
    }
}
