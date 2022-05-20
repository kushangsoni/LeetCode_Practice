
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    public class FindLengthOfLongestSubString
    {
        public static int LengthOfLongestSubstring(string s)
        {
            //early approach
            //List<string> list = new List<string>();
            //int retVal=0;
            //string uniqueCharinString = "";
            //for (int j = 0; j < s.Length; j++)
            //{
            //    uniqueCharinString = "";
            //    for (int i = j; i < s.Length; i++)
            //    {
            //        if (uniqueCharinString.IndexOf(s[i]) == -1)
            //        {
            //            uniqueCharinString += s[i];
            //            if (i == s.Length - 1)
            //            {// if last character then add that substring to list
            //                retVal = Math.Max(uniqueCharinString.Length, retVal);
            //            }
            //        }
            //        else


            //        {
            //            retVal = Math.Max(uniqueCharinString.Length, retVal);
            //            uniqueCharinString = "" + s[i];
            //            if (i == s.Length - 1) {
            //                // if last char then add it to list
            //                retVal = Math.Max(uniqueCharinString.Length, retVal);
            //            }
            //        }
            //    }
            //}

            //return retVal;







            /// new approach
            int startIndex = 0; int endIndex = 0;
            string uniueChar = "";
            int maxLength = 0;
            while (endIndex < s.Length)
            {
                if (uniueChar.IndexOf(s[endIndex]) == -1)
                {
                    // add the char to UniqueChar string
                    uniueChar += s[endIndex];
                    endIndex++;
                    maxLength = Math.Max(maxLength, uniueChar.Length);
                }
                else
                {
                    // remove the char from UniqeChar String
                    uniueChar =  uniueChar.Trim(s[startIndex]);
                    startIndex++;
                }
            }
            return maxLength;
        }
    }
}
