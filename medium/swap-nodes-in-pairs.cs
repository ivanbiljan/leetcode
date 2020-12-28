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
    public ListNode SwapPairs(ListNode head) {
        var result = new ListNode(0);
        result.next = head;
        
        var current = result;
        while (current.next != null && current.next.next != null) {
            var firstNode = current.next;
            var secondNode = current.next.next;
            
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;
            current.next = secondNode;
            current = firstNode;
        }
        
        return result.next;
    }
}