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
        if (head == null) {
            return null;
        }
        
        var dummy = new ListNode();
        dummy.next = head;
        var fast = dummy;
        for (var i = 0; i < n; ++i) {
            fast = fast.next;
        }
        
        var slow = dummy;
        while (fast.next != null) {
            slow = slow.next;
            fast = fast.next;
        }
        
        slow.next = slow.next.next;
        return dummy.next;
    }
}