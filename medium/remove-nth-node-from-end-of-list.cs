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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null || head.next == null) {
            return null;
        }
        
        var dummy = new ListNode(0, head);
        
        var slow = dummy;
        var fast = dummy.next;
        for (;n - 1 > 0;--n) {
            fast = fast.next;
        }
        
        while (fast != null && fast.next != null) {
            fast = fast.next;
            slow = slow.next;
        }
        
        slow.next = slow.next.next;
        return dummy.next;
    }
}