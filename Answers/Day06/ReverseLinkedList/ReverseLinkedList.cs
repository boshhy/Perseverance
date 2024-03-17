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

public class Solution
{
    // Method to reverse a linked list
    public ListNode ReverseList(ListNode head)
    {
        // Initialize two pointers, 'left' and 'right', to null
        ListNode left = null;
        ListNode right = null;

        // Iterate through the linked list
        while (head != null)
        {
            // Store the next node of 'head' in 'right' to avoid losing the reference
            right = head.next;
            // Reverse the link of 'head' to point to the previous node 'left'
            head.next = left;
            // Move 'left' pointer to the current node 'head'
            left = head;
            // Move 'head' pointer to the next node in the original list
            head = right;
        }
        // 'left' now points to the last node of the original list, which is the first node of the reversed list
        return left; // Return the new head of the reversed list
    }
}
