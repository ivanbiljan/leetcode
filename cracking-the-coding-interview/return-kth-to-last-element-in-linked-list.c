typedef struct Node {
    int val;
    struct Node* next;
} Node;

// 1->2->3->4->5->6, k = 1 => node = 5->6
Node* returnKthToLast(Node* head, int k) {
    if (head == NULL || head->next == NULL) {
        return head;
    }

    return NULL;
}