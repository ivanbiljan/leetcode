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
    public ListNode RemoveNodes(ListNode head) {
        if (head.next is null) {
            return head;
        }

        var reversed = Reverse(head);
        var walker = reversed;
        var max = reversed.val;
        while (walker?.next is not null) {
            while (walker.next?.val < max) {
                walker.next = walker.next.next;
            }

            max = Math.Max(max, walker.next?.val ?? 0);
            walker = walker.next;
        }

        return Reverse(reversed);
    }

    private ListNode Reverse(ListNode head) {
        ListNode? prev = null, current = head;
        while (current is not null) {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}