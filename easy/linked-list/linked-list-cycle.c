/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
bool hasCycle(struct ListNode *head) {
    if (head == NULL || head->next == NULL) {
        return false;
    }
    
    struct ListNode *slowPtr = head;
    struct ListNode *fastPtr = head->next;
    while (slowPtr != NULL && fastPtr != NULL && fastPtr->next != NULL) {
        if (slowPtr == fastPtr) {
            return true;
        }
        
        slowPtr = slowPtr->next;
        fastPtr = fastPtr->next->next;
    }
    
    return false;
}