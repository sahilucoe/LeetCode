using System.Collections.Generic;

namespace Problems
{
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var hasCycle = false;
            if (head == null)
                return false;
            else
            {
                var hashSet = new HashSet<ListNode>();
                while (head != null)
                {
                    if (hashSet.Contains(head))
                    {
                        hasCycle = true;
                    }
                    hashSet.Add(head);
                    head = head.next;
                }
            }
            return hasCycle;
        }
    }
}
