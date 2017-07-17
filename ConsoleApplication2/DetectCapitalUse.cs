using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DetectCapitalUse
    {

        //Try with regular Expression

        public bool DetectCapital(string word)
        {
            Regex regex = new Regex(@"[A-Z]+[a-z]+[A-Z][a-z]+");            
            Match m = regex.Match(word);
            if (m.Success)
            {
                return true;
            }

            return false;


            //public bool DetectCapital(string word)
            //{
            //    char[] chrArry = word.ToCharArray();
            //    int iAllCaps = 0;
            //    int iAllSmall = 0;
            //    for ( int i = 0; i < word.Length; i ++)
            //    {
            //        if ( Convert.ToInt32(chrArry[i]) <= 90 )
            //        {
            //            iAllCaps++;
            //        }
            //        else if (Convert.ToInt32(chrArry[i]) > 90)
            //        {
            //            iAllSmall++;
            //        }

            //    }

            //    if ( (iAllSmall == 0 && iAllCaps > 0) || (iAllSmall > 0 && iAllCaps == 0) )
            //    {
            //        return true;
            //    }
            //    else if (iAllSmall > 0 && iAllCaps > 0 && chrArry[0] > 90)
            //    {
            //        return false;
            //    }
            //    else if (iAllCaps == 1 && iAllSmall > 0 && chrArry[0] <= 90 )
            //    {
            //        return true;
            //    }

            //    return false;
            //}
        }
    }
}
