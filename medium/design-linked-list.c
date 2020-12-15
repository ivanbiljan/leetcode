typedef struct Node {
    int val;
    struct Node* next;
} Node;

typedef struct {
    Node* head;
} MyLinkedList;

/** Miscellaneous functions */
Node* createNode(int val) {
    Node* node = malloc(sizeof(Node));
    node->val = val;
    node->next = NULL;
    return node;
}

/** Initialize your data structure here. */

MyLinkedList* myLinkedListCreate() {
    MyLinkedList* list = malloc(sizeof(MyLinkedList));
    list->head = NULL;
    return list;
}

/** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
int myLinkedListGet(MyLinkedList* obj, int index) {
    Node* current = obj->head;
    while (index > 0 && current != NULL) {
        current = current->next;
        --index;
    }
    
    return index > 0 || current == NULL ? -1 : current->val;
}

/** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
void myLinkedListAddAtHead(MyLinkedList* obj, int val) {
    Node* newNode = malloc(sizeof(Node));
    newNode->val = val;
    newNode->next = obj->head;
    obj->head = newNode;
}

/** Append a node of value val to the last element of the linked list. */
void myLinkedListAddAtTail(MyLinkedList* obj, int val) {
    if (obj->head == NULL) {
        myLinkedListAddAtHead(obj, val);
        return;
    }
    
    Node* current = obj->head;
    while (current->next != NULL) {
        current = current->next;
    }
    
    current->next = createNode(val);
}

/** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
void myLinkedListAddAtIndex(MyLinkedList* obj, int index, int val) {
    if (index == 0) {
        myLinkedListAddAtHead(obj, val);
        return;
    }
    
    Node* current = obj->head;
    while (index - 1 > 0 && current != NULL) {
        current = current->next;
        --index;
    }
    
    if (index - 1 > 0) {
        return;
    }
    
    Node* previousNext = current->next;
    Node* newNode = createNode(val);
    newNode->next = previousNext;
    current->next = newNode;
}

/** Delete the index-th node in the linked list, if the index is valid. */
void myLinkedListDeleteAtIndex(MyLinkedList* obj, int index) {
    if (index == 0 && obj->head != NULL) {
        obj->head = obj->head->next;
        return;
    }
    
    Node* current = obj->head;
    while (index - 1 > 0 && current != NULL) {
        current = current->next;
        --index;
    }
    
    if (index - 1 > 0 || current == NULL || current->next == NULL) {
        return;
    }
    
    current->next = current->next->next;
}

void myLinkedListFree(MyLinkedList* obj) {
    Node* current = obj->head;
    Node* next = NULL;
    while (current != NULL) {
        next = current->next;
        free(current);
        current = next;
    }
    
    free(obj);
}

/**
 * Your MyLinkedList struct will be instantiated and called as such:
 * MyLinkedList* obj = myLinkedListCreate();
 * int param_1 = myLinkedListGet(obj, index);
 
 * myLinkedListAddAtHead(obj, val);
 
 * myLinkedListAddAtTail(obj, val);
 
 * myLinkedListAddAtIndex(obj, index, val);
 
 * myLinkedListDeleteAtIndex(obj, index);
 
 * myLinkedListFree(obj);
*/