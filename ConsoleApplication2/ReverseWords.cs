using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ReverseWordsClass
    {
        public string ReverseWords(string s)
        {
            char[] charArry;
            StringBuilder sb = new StringBuilder();
            string[] split = s.Split(new Char[] { ' '});
            foreach ( string rev in split)
            {
                charArry = rev.ToCharArray();
                Array.Reverse(charArry);
                sb.Append(charArry);
                sb.Append(' ');
            }

           return sb.ToString().Trim();
        }
    }
}
