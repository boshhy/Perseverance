// Overview
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        // The given code merges an array of sorted linked lists into a single sorted linked list. 
        // It first checks if the input array is empty or null, returning null if so. Then, it iteratively merges 
        // adjacent lists in the array, doubling the interval each time until all lists are merged into one. 
        // Finally, it returns the merged list.
    }

    // This code defines a method that merges two sorted linked lists into a single sorted linked list. It iterates 
    // through both lists, comparing the values of their nodes, and appends the smaller node to the merged list. 
    // It then appends any remaining nodes from the non-empty list to the merged list and returns the merged list.
}

// Comments
public class Solution
{
    // This method merges an array of sorted linked lists into a single sorted linked list.
    public ListNode MergeKLists(ListNode[] lists)
    {
        // If the input array is null or empty, return null.

        // Initialize the interval to 1 for the merge operation.

        // Loop until the interval reaches the length of the input array.
        //     Merge adjacent lists with the current interval.
        //         Merge two lists at the current index and index + interval.
        //     Double the interval for the next iteration.

        // Return the first element of the merged list, which is the result.
    }

    // This method merges two sorted linked lists into a single sorted linked list.
    //     Create a temporary node to store the merged list.
    //     Create a reference to the current node in the merged list.

    //     Traverse both lists until one of them becomes null.
    //         Compare the values of the current nodes in the two lists.
    //         Append the smaller value to the merged list and move to the next node in that list.
    //         Move the current node pointer in the merged list to the next node.

    //     Append the remaining nodes from the non-null list to the merged list.

    //     Return the merged list starting from the next node of the temporary node.
}

// Pseudocode
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        // if lists is null or lists.Length is 0:
        //     return null

        // interval = 1

        // while interval < lists.Length:
        //     for index from 0 to lists.Length - interval with step interval * 2:
        //         lists[index] = MergeTwoLists(lists[index], lists[index + interval])
        //     interval *= 2

        // return lists[0]
    }

    // function MergeTwoLists(list1, list2):
    //     tempNode = new ListNode()
    //     currentNode = tempNode

    //     while list1 is not null and list2 is not null:
    //         if list1.val is less than or equal to list2.val:
    //             currentNode.next = list1
    //             list1 = list1.next
    //         else:
    //             currentNode.next = list2
    //             list2 = list2.next
    //         currentNode = currentNode.next

    //     currentNode.next = list1 if list1 is not null else list2

    //     return tempNode.next
}
