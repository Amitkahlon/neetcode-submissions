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
public void ReorderList(ListNode head)
{
    ListNode fast = head;
    ListNode slow = head;

    while (fast is not null && fast.next is not null && fast.next.next is not null)
    {
        fast = fast.next.next;
        slow = slow.next;
    }

    var secondHalf = slow.next;
    slow.next = null;

    var revCurr = ReverseList(secondHalf);
    var curr = revCurr;
    var prev = head;

    while (curr is not null)
    {
        var newCurr = prev.next;
        prev.next = curr;
        prev = curr;
        curr = newCurr;
    }
}

            public ListNode ReverseList(ListNode head)
            {
                if (head == null) return head;

                ListNode prev = head;
                ListNode curr = head.next;


                while (curr is not null)
                {
                    ListNode next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }

                head.next = null;

                return prev;
            }

}
