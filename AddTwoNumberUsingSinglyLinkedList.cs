using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practice
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

    }
    public class AddTwoNumberUsingSinglyLinkedList
    {
        //Add Two Numbers using Singly LinkedList
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ListThree = new ListNode();
            while (l1 != null || l2 != null)
            {
                int carry, val1, val2, val3;
                val1 = l1?.val ?? 0;
                val2 = l2?.val ?? 0;
                val3 = ListThree?.val ?? 0;

                // previous carry + Val1 + val2
                int sum = val1 + val2 + val3;

                carry = sum / 10;
                sum = sum % 10;

                ListThree.val = sum;
                if (l1?.next != null || l2?.next != null || carry > 0)
                {
                    ListThree = new ListNode(carry, ListThree);
                }
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }

            }

            return ReverseSinglyList(ListThree);

        }
        // reverse singly linked list
        public static ListNode ReverseSinglyList(ListNode singlyList)
        {
            int temp = singlyList?.val??0;
            ListNode tempList = new ListNode();
            bool loopthrough = singlyList != null;

            while (loopthrough)
            {
                temp = singlyList.val;
                if (singlyList.next != null)
                {
                    singlyList = singlyList.next;
                    tempList.val = temp;
                    tempList = new ListNode(0, tempList);
                }
                else
                {
                    loopthrough = false;
                    tempList.val = temp;
                }
            }
            return tempList;
        }
        public static void Main(String[] args)
        {
            ListNode elementOne = new ListNode(3);
            ListNode elementTwo = new ListNode(4, elementOne);
            ListNode elementThree = new ListNode(0);


            ListNode eleOne = new ListNode(4);
            ListNode eletTwo = new ListNode(6, eleOne);
            ListNode eleThree = new ListNode(1);

            ListNode ListOne = elementThree;
            ListOne = ReverseSinglyList(ListOne);
            ListNode ListTwo = eleThree;
            ListTwo = ReverseSinglyList(ListTwo);

            // Following Code is just for understanding and checking Output of Logic Applied
            ListNode ListThree = new ListNode();
            ListThree = AddTwoNumbers(ListOne, ListTwo);


            while (ListThree != null)
            {
                Console.WriteLine("{0}", ListThree.val);
                ListThree = ListThree.next;
            }
            Console.ReadLine();
        }
    }
}
