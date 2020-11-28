/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */

// Iterative
struct ListNode* reverseList(struct ListNode* head){
    struct ListNode *prev = NULL, *next = NULL;
    while (head) {
        next = head->next;
        head->next = prev;
        prev = head;
        head = next;
    }
    
    return prev;
}

// Recrusive
/*struct ListNode* reverseList(struct ListNode* head){
    if (head == NULL || head->next == NULL) {
        return head;
    }
    
    struct ListNode *node = reverseList(head->next);
    head->next->next = node;
    head->next = NULL;
    return node;
}*/