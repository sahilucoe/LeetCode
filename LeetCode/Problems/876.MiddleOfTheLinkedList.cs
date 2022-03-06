namespace Problems
{
	class MiddleOfTheLinkedList
	{
		public ListNode MiddleNode(ListNode head)
		{
			var jump = head;
			var jumpTwice = head;

			while(jumpTwice != null && jumpTwice.next!=null && jumpTwice.next.next != null)
            {
				jump = jump.next;
				jumpTwice = jumpTwice.next.next;
            }
            
			if (jumpTwice.next == null)
            {
				return jump;
            }
			if (jumpTwice.next.next == null)
			{
				return jump.next;
			}

			// redundant, can return null here
			return head;
		}
	}
}
