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
    public ListNode ReverseList(ListNode head) {
        // if (head?.next is null) {
        //     return head;
        // }

        // var next = head.next.next;
        // head.next = null;
        // head.next.next = head;

        // var reversed = ReverseList(next);
        // reversed.next.next = head;

        // return reversed;
        ListNode walker = head, prev = null;
        while (walker != null) {
            ListNode next = walker.next;
            walker.next = prev;
            prev = walker;
            walker = next;
        }

        return prev;
    }
}