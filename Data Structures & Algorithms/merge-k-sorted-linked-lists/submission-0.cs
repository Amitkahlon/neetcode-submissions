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
           public ListNode MergeKLists(ListNode[] lists)
           {
               if (lists.Length == 1) return lists[0];
if (lists.Length == 0) return null;
               int l = 0;
               int r = lists.Length - 1;

               Queue<ListNode> merge = new Queue<ListNode>(lists);

               while (merge.Count >= 2)
               {
                   var a = merge.Dequeue();
                   var b = merge.Dequeue();

                   var c = MergeTwoLists(a, b);
                   merge.Enqueue(c);
               }

               return merge.Dequeue();
           }
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
