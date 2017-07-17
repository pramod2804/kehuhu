using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] cnt = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                cnt[magazine[i] - 'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (--cnt[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
