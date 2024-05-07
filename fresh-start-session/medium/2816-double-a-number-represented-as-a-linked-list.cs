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
    public ListNode DoubleIt(ListNode head) {
        ListNode root = new ListNode(val: 0, next: head), prev = root, curr = root.next;
        while (curr != null) {
            if (curr.val < 5) {
                curr.val *= 2;
            } else {
                curr.val = curr.val * 2 % 10;
                prev.val += 1;
            }

            prev = curr;
            curr = curr.next;
        }

        return root.val > 0 ? root : root.next;
    }
}