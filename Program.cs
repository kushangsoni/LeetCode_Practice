using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*---------------- Logic to Show Output of Problem1: GetIndexOfElements --------------------------------
            //  following code is for the problem mentioned in the below link
            //    Link: https://leetcode.com/problems/two-sum/
            
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            var output = P1_GetIndexesOfElements.getIndexesOfElements(nums, target);
            Console.WriteLine("{0}-{1}", output[0], output[1]);

            // remove following code while applying code to Leetcode Problem
            Console.ReadLine();
            
             -------------------------- End Of Problem1: GetIndexOfElements ----------------------------------------*/

            /*---------------- Logic to Show Output of Problem1: AddTwoNumberUsingSinglyLinkedList -----------------
             
            ListNode elementOne = new ListNode(3);
            ListNode elementTwo = new ListNode(4, elementOne);
            ListNode elementThree = new ListNode(0);


            ListNode eleOne = new ListNode(4);
            ListNode eletTwo = new ListNode(6, eleOne);
            ListNode eleThree = new ListNode(1);

            ListNode ListOne = elementThree;
            ListOne = AddTwoNumberUsingSinglyLinkedList.ReverseSinglyList(ListOne);
            ListNode ListTwo = eleThree;
            ListTwo = AddTwoNumberUsingSinglyLinkedList.ReverseSinglyList(ListTwo);

            // Following Code is just for understanding and checking Output of Logic Applied
            ListNode ListThree = new ListNode();
            ListThree = AddTwoNumberUsingSinglyLinkedList.AddTwoNumbers(ListOne, ListTwo);


            while (ListThree != null)
            {
                Console.WriteLine("{0}", ListThree.val);
                ListThree = ListThree.next;
            }
            Console.ReadLine();
            ----------------------------------- End Of Problem2: AddTwoNumberUsingSinglyLinkedList ------------------------*/


            //string s = "asjrgapb";
            //Console.WriteLine(FindLengthOfLongestSubString.LengthOfLongestSubstring(s));
            Console.WriteLine(WrongCharacterFinder.find());
            Console.ReadLine();


        }

    }
}