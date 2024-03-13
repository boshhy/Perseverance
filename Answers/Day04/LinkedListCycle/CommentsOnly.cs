// Overview
public class Solution
{
    // Method to detect a cycle in a linked list using the "tortoise and hare" algorithm.
    // It takes the head of the linked list as input and returns true if a cycle is detected, otherwise false.
    public bool HasCycle(ListNode head)
    {
        // It uses the "tortoise and hare" algorithm, where two pointers move through the list at different speeds. 
        // If they meet at some point, it indicates the presence of a cycle, and the method returns true. 
        // Otherwise, if the hare reaches the end of the list, the method returns false, indicating no cycle is present.
    }
}


// Comments
public class Solution
{
    // Method to detect a cycle in a linked list using the "tortoise and hare" algorithm.
    // It takes the head of the linked list as input and returns true if a cycle is detected, otherwise false.
    public bool HasCycle(ListNode head)
    {
        // Initialize two pointers: tortoise and hare, both starting from the head of the linked list.

        // Iterate through the linked list using the hare pointer.
        // The hare pointer moves twice as fast as the tortoise pointer.
        //     Move the tortoise pointer one step forward.
        //     Move the hare pointer two steps forward.

        //     If the tortoise and hare pointers meet at some node,
        //     it indicates the presence of a cycle in the linked list.
        //         Return true to indicate the presence of a cycle.

        // If the hare pointer reaches the end of the linked list (i.e., becomes null),
        // it indicates that there is no cycle in the linked list.
        //     Return false to indicate no cycle is detected.
    }
}


// Pseudocode
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        // tortoise = head
        // hare = head

        // while hare is not null AND hare.next is not null:
        //     tortoise = tortoise.next
        //     hare = hare.next.next

        //     if hare equals tortoise:
        //         return true

        // return false
    }
}