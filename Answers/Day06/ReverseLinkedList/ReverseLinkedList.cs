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
    // Method to reverse a singly-linked list, taking the head node as input and returning the new head node.
    public ListNode ReverseList(ListNode head)
    {
        // Initialize a pointer to keep track of the previous node, initially set to null.
        ListNode prev = null;
        // Initialize a pointer to keep track of the current node, initially set to null.                   
        ListNode current = null;

        // Iterate through the linked list until the current node becomes null.
        while (head != null)
        {
            // Set the current node to the head of the list.
            current = head;
            // Move the head to the next node, advancing the iteration.                 
            head = head.next;
            // Reverse the link of the current node to point to the previous node.              
            current.next = prev;
            // Move the previous pointer to the current node for the next iteration.                
            prev = current;
        }
        // Return the last node processed, which becomes the new head of the reversed list.
        return current;
    }
}