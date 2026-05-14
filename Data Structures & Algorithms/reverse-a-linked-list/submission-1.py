# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head: return None
        if not head.next: return head

        stack = [head]
        curr = head.next
        head.next = None
        
        while curr.next:
            stack.append(curr)
            curr = curr.next
        
        newHead = curr

        while stack:
            curr.next = stack.pop()
            curr = curr.next
            curr.next = None
        

        return newHead




        
        