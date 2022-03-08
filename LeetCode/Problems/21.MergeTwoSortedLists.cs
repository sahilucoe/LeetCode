namespace Problems
{
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null && list2 == null)
            {
                return null;
            }
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode current;
            if (list1.val < list2.val)
            {
                current = list1;
                list1 = list1.next;
            }
            else
            {
                current = list2;
                list2 = list2.next;
            }
            var root = current;

            while(list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            while (list1 != null)
            {
                current.next = list1;
                current = current.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                current.next = list2;
                current = current.next;
                list2 = list2.next;
            }
            return root;
        }
    }
}
