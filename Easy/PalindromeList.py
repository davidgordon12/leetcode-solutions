# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        fast = head
        slow = head

        # find middle of list
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next

        # reverse 2nd half of list
        prev = None
        while slow:
            next = slow.next
            slow.next = prev
            prev = slow
            slow = next

        left = head
        right = prev

        while right:
            if left.val != right.val:
                return False
            right = right.next
            left = left.next

        return True
