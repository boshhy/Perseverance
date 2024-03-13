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
    public bool HasCycle(ListNode head)
    {
        ListNode tortoise = head;
        ListNode hare = head;

        while (hare != null && hare.next != null)
        {
            tortoise = tortoise.next;
            hare = hare.next.next;

            if (hare == tortoise)
            {
                return true;
            }
        }
        return false;
    }
}