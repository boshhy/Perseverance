public partial class MergeTwoListsSolution
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Initialize a temporary node to start the merged list
        ListNode tempNode = new ListNode();
        ListNode currentNode = tempNode; // Reference to the current node, starting at the temp node

        // Iterate through both lists until either becomes null
        while (list1 != null && list2 != null)
        {
            // Choose the smaller value between list1 and list2
            if (list1.val < list2.val)
            {
                currentNode.next = list1; // Append list1 node to the merged list
                list1 = list1.next; // Move to next node in list1
            }
            else
            {
                currentNode.next = list2; // Append list2 node to the merged list
                list2 = list2.next; // Move to next node in list2
            }
            currentNode = currentNode.next; // Move to the next node in the merged list
        }

        // Append remaining nodes from list1 or list2, if any
        currentNode.next = (list1 != null) ? list1 : list2;

        // Return the merged list, excluding the temp node
        return tempNode.next;
    }
}
