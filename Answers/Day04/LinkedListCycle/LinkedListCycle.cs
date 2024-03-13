/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class Solution
{
    // Method to detect a cycle in a linked list using the "tortoise and hare" algorithm.
    // It takes the head of the linked list as input and returns true if a cycle is detected, otherwise false.
    public bool HasCycle(ListNode head)
    {
        // Initialize two pointers: tortoise and hare, both starting from the head of the linked list.
        ListNode tortoise = head;
        ListNode hare = head;

        // Iterate through the linked list using the hare pointer.
        // The hare pointer moves twice as fast as the tortoise pointer.
        while (hare != null && hare.next != null)
        {
            // Move the tortoise pointer one step forward.
            tortoise = tortoise.next;
            // Move the hare pointer two steps forward.
            hare = hare.next.next;

            // If the tortoise and hare pointers meet at some node,
            // it indicates the presence of a cycle in the linked list.
            if (hare == tortoise)
            {
                return true; // Return true to indicate the presence of a cycle.
            }
        }

        // If the hare pointer reaches the end of the linked list (i.e., becomes null),
        // it indicates that there is no cycle in the linked list.
        return false; // Return false to indicate no cycle is detected.
    }
}
