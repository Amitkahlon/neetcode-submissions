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
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode dummy = new ListNode();
                dummy.next = head;
                ListNode l = dummy;
                ListNode r = dummy;
                ListNode prev = null;


                for (int i = 0; i < n; i++)
                {
                    r = r.next;
                }

                while (r is not null)
                {
                    prev = l;
                    r = r.next;
                    l = l.next;
                }

                prev.next = l.next;
                l.next = null;

                return dummy.next;

            }
}
