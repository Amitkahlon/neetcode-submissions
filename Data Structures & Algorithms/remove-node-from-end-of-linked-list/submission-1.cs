/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
            public int RemoveNthFromEnd(ListNode curr, ListNode prev, int n)
            {
                if (curr == null) return 0;
                var nFromEnd = RemoveNthFromEnd(curr.next, curr, n) + 1;

                if (n == nFromEnd)
                {
                    if (prev is not null) prev.next = curr.next;
                    curr.next = null;
                }

                return nFromEnd;
            }

            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                var dummy = new ListNode();
                dummy.next = head;

                RemoveNthFromEnd(dummy, null, n);
                return dummy.next;
            }
}
