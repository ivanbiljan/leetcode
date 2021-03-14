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
    public ListNode SwapNodes(ListNode head, int k) {
        var firstNode = default(ListNode);
        var secondNode = default(ListNode);
        
        var walker = head;
        while (walker != null) {
            secondNode = secondNode?.next;
            if (--k == 0) {
                firstNode = walker;
                secondNode = head;
            }
            
            walker = walker.next;
        }
        
        var temp = firstNode.val;
        firstNode.val = secondNode.val;
        secondNode.val = temp;
        
        return head;
    }
}