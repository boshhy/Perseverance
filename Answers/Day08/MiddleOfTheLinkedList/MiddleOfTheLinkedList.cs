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
    // Define a method named MiddleNode which finds the middle node of a singly-linked list
    public ListNode MiddleNode(ListNode head)
    {
        // Initialize two pointers, tortoise and hare, both pointing to the head of the list
        ListNode tortoise = head;
        ListNode hare = head;

        // Move the hare pointer twice as fast as the tortoise pointer until hare reaches the end of the list
        // When hare reaches the end, tortoise will be at the middle node
        while (hare != null && hare.next != null)
        {
            hare = hare.next.next; // Move hare two steps forward
            tortoise = tortoise.next; // Move tortoise one step forward
        }

        // Return the node where tortoise is currently pointing, which is the middle node
        return tortoise;
    }
}
