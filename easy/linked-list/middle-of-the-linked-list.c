/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */


struct ListNode* middleNode(struct ListNode* head){
    if (head == NULL || head->next == NULL) {
        return head;
    }
    
    struct ListNode* slowPtr = head;
    struct ListNode* fastPtr = head->next;
    while (fastPtr) {
        if (!fastPtr->next) {
            return slowPtr->next;
        }
        
        slowPtr = slowPtr->next;
        fastPtr = fastPtr->next->next;
    }
    
    return slowPtr;
}