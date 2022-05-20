using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    public class WrongCharacterFinder
    {
        public static int find()
        {
            string OrignalString = "ILoveCoding";
            string UserEntredString = "IILoveCCoding";
            int j = 0;
            int diff = 0;
            for (int i = 0; i < UserEntredString.Length; i++)
            {
                if (UserEntredString[i] == OrignalString[j])
                {
                    j++;
                }
                else { 
                    diff++;
                }
            }
            return j==OrignalString.Length ?diff: -1;
        }

    }
}
