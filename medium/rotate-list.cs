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
    public ListNode RotateRight(ListNode head, int k) {
        // TODO: optimizations
        
        // Naive/intuitive solution
        if (head == null || head.next == null) {
            return head;
        }
        
        var length = 1;
        var lengthWalker = head;
        while (lengthWalker.next != null) {
            lengthWalker = lengthWalker.next;
            ++length;
        }
        
        for (var i = 0; i < k % length; ++i) {
            var walker = head;
            while (walker.next != null && walker.next.next != null) {
                walker = walker.next;
            }
            
            walker.next.next = head;
            head = walker.next;
            walker.next = null;
        }
        
        return head;
    }
}