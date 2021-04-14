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
    public ListNode Partition(ListNode head, int x) {
        // [5, 4, 3, 2, 1], x = 5
        
        if (head == null) {
            return null;
        }
        
        var less = new ListNode();
        var lessWalker = less;
        
        var greater = new ListNode();
        var greaterWalker = greater;
        
        while (head != null) {
            if (head.val < x) {
                lessWalker.next = new ListNode(head.val);
                lessWalker = lessWalker.next;
            }
            else {
                greaterWalker.next = new ListNode(head.val);
                greaterWalker = greaterWalker.next;
            }
            
            head = head.next;
        }
        
        lessWalker.next = greater.next;
        return less.next;
    }
}