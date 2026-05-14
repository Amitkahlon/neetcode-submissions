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
   public ListNode MergeTwoLists(ListNode list1, ListNode list2)
 {
     ListNode curr1 = list1;
     ListNode curr2 = list2;

     ListNode first;
     ListNode newList;

     if (curr1 is not null && curr1.val < curr2?.val)
     {
         newList = curr1;
         curr1 = curr1.next;
     }
     else if (curr2 is not null)
     {
         newList = curr2;
         curr2 = curr2.next;
     }
     else { return list1; }

     first = newList;

     while (curr1 is not null && curr2 is not null)
     {
         if (curr1.val < curr2.val)
         {
             newList.next = curr1;
             curr1 = curr1.next;
         }
         else
         {
             newList.next = curr2;
             curr2 = curr2.next;
         }

         newList = newList.next;

     }

     if (curr1 is not null)
     {
         newList.next = curr1;
     }

     if (curr2 is not null)
     {
         newList.next = curr2;
     }

     return first;
 }
}