using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LengthOfLastWordClass
    {
        public int LengthOfLastWord(string s)
        {
            if ( s.Trim().Length == 0 )
            {
                return 0;
            }
            int lenOfLast = 0;
            string[] substr = s.Split(new char[] { ' ' });
            foreach ( string str in substr)
            {
                str.Trim();
                lenOfLast = Math.Max(lenOfLast, str.Length);
            }
            return lenOfLast;
        }
    }
}
