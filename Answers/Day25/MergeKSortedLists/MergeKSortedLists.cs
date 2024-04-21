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
    // This method merges an array of sorted linked lists into a single sorted linked list.
    public ListNode MergeKLists(ListNode[] lists)
    {
        // If the input array is null or empty, return null.
        if (lists == null || lists.Length == 0)
        {
            return null;
        }

        // Initialize the interval to 1 for the merge operation.
        int interval = 1;

        // Loop until the interval reaches the length of the input array.
        while (interval < lists.Length)
        {
            // Merge adjacent lists with the current interval.
            for (int index = 0; index + interval < lists.Length; index += interval * 2)
            {
                // Merge two lists at the current index and index + interval.
                lists[index] = MergeTwoLists(lists[index], lists[index + interval]);
            }
            // Double the interval for the next iteration.
            interval *= 2;
        }

        // Return the first element of the merged list, which is the result.
        return lists[0];
    }

    // This method merges two sorted linked lists into a single sorted linked list.
    ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Create a temporary node to store the merged list.
        ListNode tempNode = new ListNode();
        // Create a reference to the current node in the merged list.
        ListNode currentNode = tempNode;

        // Traverse both lists until one of them becomes null.
        while (list1 != null && list2 != null)
        {
            // Compare the values of the current nodes in the two lists.
            // Append the smaller value to the merged list and move to the next node in that list.
            if (list1.val <= list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }
            // Move the current node pointer in the merged list to the next node.
            currentNode = currentNode.next;
        }

        // Append the remaining nodes from the non-null list to the merged list.
        currentNode.next = (list1 != null) ? list1 : list2;

        // Return the merged list starting from the next node of the temporary node.
        return tempNode.next;
    }
}
