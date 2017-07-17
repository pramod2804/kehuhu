using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class KeyBoardRow
    {
        //Can be improved by using Regex
        public string[] FindWords(string[] words)
        {
            List<string> returnWords = new List<string>();            
            char[] line1 = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' , 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            char[] line2 = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            char[] line3 = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            foreach ( string str in words)
            {
                char[] arr = str.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (line1.Contains(arr[i]))
                    {
                        if (i == (arr.Length - 1))
                        {
                            returnWords.Add(str);                            
                            break;
                        }
                    }
                    else
                        break;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (line2.Contains(arr[i]))
                    {
                        if (i == (arr.Length - 1))
                        {
                            returnWords.Add(str);
                            break;
                        }
                    }
                    else
                        break;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (line3.Contains(arr[i]))
                    {
                        if (i == (arr.Length - 1))
                        {
                            returnWords.Add(str);
                            break;
                        }
                    }
                    else
                        break;
                }                               
                
            }
            return returnWords.ToArray(); ;
        }        

    }
}
