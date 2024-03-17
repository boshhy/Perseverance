// Overview
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // The method iterates through the list, updating pointers to reverse the links between nodes. 
        // It initializes two pointers, left and right, to manage the reversal process. 
        // Using a while loop, it traverses the list, adjusting pointers to reverse the direction of links between nodes. 
        // Finally, it returns the new head (left) of the reversed list
    }
}

// Comments
public class Solution
{
    // Method to reverse a linked list
    public ListNode ReverseList(ListNode head)
    {
        // Initialize two pointers, 'left' and 'right', to null

        // Iterate through the linked list
        //     Store the next node of 'head' in 'right' to avoid losing the reference
        //     Reverse the link of 'head' to point to the previous node 'left'
        //     Move 'left' pointer to the current node 'head'
        //     Move 'head' pointer to the next node in the original list
        // 'left' now points to the last node of the original list, which is the first node of the reversed list

        // Return the new head of the reversed list  
    }
}

// Pseudocode
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // left = null
        // right = null

        // while head is not null:
        //     right = head.next
        //     head.next = left
        //     left = head
        //     head = right

        // return left
    }
}