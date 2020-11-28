/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */

struct ListNode* reverseListIteratively(struct ListNode* head);

bool isPalindrome(struct ListNode* head){
    if (head == NULL || head->next == NULL) {
        return true;
    }
    
    struct ListNode* slowPtr = head;
    struct ListNode* fastPtr = head->next;
    while (fastPtr != NULL && fastPtr->next) {        
        slowPtr = slowPtr->next;
        fastPtr = fastPtr->next->next;
    }
    
    struct ListNode* reversedHead = reverseListIteratively(slowPtr);
    while (head != NULL && reversedHead != NULL) {
        if (head->val != reversedHead->val) {
            return false;
        }
        
        head = head->next;
        reversedHead = reversedHead->next;
    }
    
    return head == NULL;
}

struct ListNode* reverseListIteratively(struct ListNode* head) {
    if (head == NULL || head->next == NULL) {
        return head;
    }
    
    struct ListNode* prev = NULL;
    struct ListNode* next = NULL;
    while (head != NULL) {
        next = head->next;
        head->next = prev;
        prev = head;
        head = next;
    }
    
    return prev;
}