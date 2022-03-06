using System.Collections;
using System.Collections.Generic;

namespace Problems
{
    internal class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var start = new ListNode();
            var root = start;
            while (l1 != null && l2 != null)
            {
                var sum = l1.val + l2.val + carry;
                carry = sum / 10;

                start.next = new ListNode
                {
                    val = sum % 10
                };
                start = start.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                var sum = l1.val + carry;
                carry = sum / 10;

                start.next = new ListNode
                {
                    val = sum % 10
                };
                start = start.next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                var sum = l2.val + carry;
                carry = sum / 10;

                start.next = new ListNode
                {
                    val = sum % 10
                };
                start = start.next;
                l2 = l2.next;
            }
            if(carry != 0)
            {
                start.next = new ListNode
                {
                    val = carry
                };
            }
            return root.next;
        }
    }
}
