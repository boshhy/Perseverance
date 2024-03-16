// Overview
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // The method iterates through the list, updating pointers to reverse the links between nodes. 
        // It initializes two pointers, prev and current, to manage the reversal process. 
        // Using a while loop, it traverses the list, adjusting pointers to reverse the direction of links between nodes. 
        // Finally, it returns the new head of the reversed list
    }
}

// Comments
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // Initialize a pointer to keep track of the previous node, initially set to null.
        // Initialize a pointer to keep track of the current node, initially set to null.                   

        // Iterate through the linked list until the current node becomes null.
        //     Set the current node to the head of the list.
        //     Move the head to the next node, advancing the iteration.                 
        //     Reverse the link of the current node to point to the previous node.              
        //     Move the previous pointer to the current node for the next iteration.                
        // Return the last node processed, which becomes the new head of the reversed list.      
    }
}

// Pseudocode
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // Initialize prev pointer to null
        // Initialize current pointer to null

        // Loop while head is not null:
        //     Set current to head
        //     Move head to the next node
        //     Set current's next pointer to prev
        //     Set prev to current

        // Return current   
    }
}