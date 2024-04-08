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
        if (head?.next?.next is null) {
            return head;
        }

        ListNode temp = new ListNode(next: head), odd = head, even = head.next, evenCpy = head.next;
        while (even is not null && odd.next.next is not null) {
            odd.next = odd.next?.next;
            even.next = even?.next?.next;

            odd = odd.next;
            even = even.next;
        }

        odd.next = evenCpy;

        return temp.next;
    }
}