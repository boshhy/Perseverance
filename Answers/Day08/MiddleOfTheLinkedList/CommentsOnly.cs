// Overview
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // It uses two pointers, called the "tortoise" and the "hare," which initially both point to the head of the list. 
        // The "hare" pointer moves twice as fast as the "tortoise" pointer. 
        // By advancing these pointers simultaneously, the algorithm efficiently finds the middle node of the list. 
        // When the "hare" pointer reaches the end of the list (or null), the "tortoise" pointer will be at the middle node.
    }
}

// Comments
public class Solution
{
    // Define a method named MiddleNode which finds the middle node of a singly-linked list
    public ListNode MiddleNode(ListNode head)
    {
        // Initialize two pointers, tortoise and hare, both pointing to the head of the list

        // While hare and hare.next is not out of bounds, Move the hare pointer twice as fast as the tortoise pointer
        // When hare reaches the end, tortoise will be at the middle node. 
        //     Move hare two steps forward
        //     Move tortoise one step forward

        // Return the node where tortoise is currently pointing, which is the middle node
    }
}


// Pseudocode
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // tortoise = head
        // hare = head

        // while hare is not null and hare.next is not null:
        //     hare = hare.next.next
        //     tortoise = tortoise.next

        // return tortoise
    }
}
