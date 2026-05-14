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
