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
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if (head.next == null) {
            return head;
        }

        var slow = head;
        var fast = head.next;

        while (fast?.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        return fast == null ? slow : slow.next;
    }
}