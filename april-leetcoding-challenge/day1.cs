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
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null) {
            return true;
        }
        
        var slow = head;
        var fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        var reversed = ReverseList(slow);
        while (head != null && reversed != null) {
            if (head.val != reversed.val) {
                return false;
            }
            
            head = head.next;
            reversed = reversed.next;
        }
        
        return true;
    }
    
    public ListNode ReverseList(ListNode head) {
        var prev = default(ListNode);
        while (head != null) {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        
        return prev;
    }
}