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
        if (l1 is null) {
            return l2;
        }
        
        if (l2 is null) {
            return l1;
        }
        
        bool hasCarry = (l1.val + l2.val) / 10 != 0;
        ListNode root = new ListNode((l1.val + l2.val) % 10);
        ListNode walker = root;
        
        l1 = l1.next;
        l2 = l2.next;
        while (l1 != null || l2 != null) {
            int sum = hasCarry ? 1 : 0;
            sum += l1?.val ?? 0;
            sum += l2?.val ?? 0;
            
            hasCarry = sum / 10 != 0;
            walker.next = new ListNode(sum % 10);
            walker = walker.next;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }
        
        if (hasCarry) {
            walker.next = new ListNode(1);
        }
        
        return root;
    }
}