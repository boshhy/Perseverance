public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
        {
            return null;
        }

        int interval = 1;

        while (interval < lists.Length)
        {
            for (int index = 0; index + interval < lists.Length; index += interval * 2)
            {
                lists[index] = MergeTwoLists(lists[index], lists[index + interval]);
            }
            interval *= 2;
        }

        return lists[0];
    }

    ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode tempNode = new ListNode();
        ListNode currentNode = tempNode;

        while (list1 != null && list2 != null)
        {
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
            currentNode = currentNode.next;
        }

        currentNode.next = (list1 != null) ? list1 : list2;

        return tempNode.next;
    }
}