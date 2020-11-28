/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */


struct ListNode* removeElements(struct ListNode* head, int val) {
    if (head == NULL) {
        return head;
    }
    
    while (head != NULL && head->val == val) {
        head = head->next;
    }
    
    
    struct ListNode* headCpy = head;
    while (headCpy != NULL && headCpy->next != NULL) {
        while (headCpy->next != NULL && headCpy->next->val == val) {
            headCpy->next = headCpy->next->next;
        }
        
        headCpy = headCpy->next;
    }
    
    return head;
}