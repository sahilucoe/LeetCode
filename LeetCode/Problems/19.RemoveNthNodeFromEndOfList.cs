using System.Collections.Generic;

namespace Problems
{
    internal class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var stack = new Stack<ListNode>();

            stack.Push(null);
            var iter = head;
            while (iter != null)
            {
                stack.Push(iter);
                iter = iter.next;
            }
            ListNode newNext = null;
            for(var i = 1; i < n; i++)
            {
                newNext= stack.Pop();
            }
            var toRemove = stack.Pop();
            if(toRemove == head)
            {
                return newNext;
            }
            var node = stack.Pop();

            node.next = newNext;
            return head;

        }
    }
}
