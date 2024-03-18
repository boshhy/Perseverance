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
    public ListNode MiddleNode(ListNode head)
    {
        ListNode tortoise = head;
        ListNode hare = head;

        while (hare != null && hare.next != null)
        {
            hare = hare.next.next;
            tortoise = tortoise.next;
        }

        return tortoise;
    }
}