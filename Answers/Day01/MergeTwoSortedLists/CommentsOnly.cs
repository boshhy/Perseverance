// Overview
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Initialize a temporary node to start the merged list and set a reference to the current node.
        // Iterate through both lists until either becomes null.
        // Choose the smaller value between list1 and list2:
        // Append the current node from list1 to the merged list and move to the next node in list1.
        // Append the current node from list2 to the merged list and move to the next node in list2.
        // Move to the next node in the merged list.
        // Append any remaining nodes from list1 or list2.
        // Return the merged list, excluding the temporary node.
    }
}

// Comments
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Initialize a temporary node to start the merged list
        // Reference to the current node, starting at the temp node

        // Iterate through both lists until either becomes null

        // Choose the smaller value between list1 and list2
        // Append list1 node to the merged list
        // Move to next node in list1

        // Append list2 node to the merged list
        // Move to next node in list2
        // Move to the next node in the merged list

        // Append remaining nodes from list1 or list2, if any

        // Return the merged list, excluding the temp node
    }
}

// Pseudocode
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Function MergeTwoLists(list1, list2):
        //     Create a new temporary node to start the merged list
        //     Set the current node to point to the temporary node

        //     While both list1 and list2 are not null:
        //         If the value of the current node in list1 is less than the value of the current node in list2:
        //             Set the next node of the current node to be the current node of list1
        //             Move to the next node in list1
        //         Else:
        //             Set the next node of the current node to be the current node of list2
        //             Move to the next node in list2
        //         Move the current node pointer to the newly added node in the merged list

        //     Append any remaining nodes from list1 or list2 to the merged list, if any

        //     Return the merged list, excluding the temporary node

    }
}