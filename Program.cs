using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return null;
        }
    }
    internal class Program
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
            //bool restrict = false;
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
        static void Main(string[] args)
        {
            /*  following code is for the below mentioned link
                Link: https://leetcode.com/problems/two-sum/
                int[] nums = new int[] { 3, 2, 4 };
                int target = 6;
                var output = Program.getIndexesOfElements(nums, target);
                Console.WriteLine("{0}-{1}", output[0], output[1]);
            */
            ListNode elementOne = new ListNode(1);
            ListNode elementTwo = new ListNode(2, elementOne);
            ListNode elementThree = new ListNode(3, elementTwo);

            ListNode eleOne = new ListNode(1);
            ListNode eletTwo = new ListNode(2, eleOne);
            ListNode eleThree = new ListNode(3, eletTwo);

            ListNode ListOne = elementThree;
            ListNode ListTwo = eleThree;
            ListNode ListThree = new ListNode();
           
            while (ListOne != null || ListTwo != null)
            {
                int carry, val1, val2, val3;
                val1 = ListOne?.val ?? 0;
                val2 = ListTwo?.val ?? 0;
                val3 = ListThree?.val ?? 0;
                int sum = val1 + val2 + val3;
                carry = sum / 10;
                sum = sum % 10;
                ListThree.val = sum;
                if (ListOne.next != null || ListTwo.next != null || carry > 0)
                {
                    ListThree = new ListNode(carry, ListThree);
                }
                ListOne = ListOne.next;
                ListTwo = ListTwo.next;
            }
            Console.ReadKey();
            int temp = 0;
            bool loopthrough = ListThree.next != null;
            while (loopthrough) 
            {
                if (ListThree.next != null)
                {
                    temp = ListThree.next.val;
                    ListThree.next.val = ListThree.val;
                }
                else
                {
                    loopthrough = false;
                }
            }
            ListThree.val = temp;
        }
    }
}
