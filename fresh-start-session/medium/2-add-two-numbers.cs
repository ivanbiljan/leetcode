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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var ans = new ListNode();
        var builder = ans;

        var carry = 0;
        while (l1 is not null || l2 is not null || carry > 0) {
            var l1Val = l1?.val ?? 0;
            var l2Val = l2?.val ?? 0;
            var sum = l1Val + l2Val + carry;

            builder.next = new ListNode(sum % 10);
            builder = builder.next;

            carry = sum / 10;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return ans.next;
    }
}