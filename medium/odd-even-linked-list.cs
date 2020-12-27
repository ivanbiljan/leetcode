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
    public ListNode OddEvenList(ListNode head) {
        if (head == null) {
            return null;
        }
        
        ListNode currentOdd = head;
        ListNode even = head.next;
        ListNode currentEven = head.next;
        
        while (currentEven?.next != null) {
            currentOdd.next = currentOdd.next.next;
            currentOdd = currentOdd.next;
            
            currentEven.next = currentEven.next.next;
            currentEven = currentEven.next;
        }
        
        currentOdd.next = even;
        return head;
    }
}