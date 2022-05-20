using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    public class P1_GetIndexesOfElements
    {
        /// <summary>
        /// get index of pair of elements whoes sum is equal to target
        /// </summary>
        /// <param name="nums">elements of number that must contains elements for the sum for target</param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] getIndexesOfElements(int[] nums, int target)
        {
            int[] indexes = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                int diffIndex = nums.ToList().IndexOf(diff);
                if (diffIndex > -1 && diffIndex != i)
                {
                    indexes[0] = i;
                    indexes[1] = diffIndex;
                    break;
                }
            }
            return indexes;
        }
       
    }
}
