/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     struct TreeNode *left;
 *     struct TreeNode *right;
 * };
 */


struct TreeNode* invertTree(struct TreeNode* root){
    if (root == NULL || root->left == NULL && root->right == NULL) {
        return root;
    }
    
    struct ListNode* left = root->left;
    struct ListNode* right = root->right;
    root->left = invertTree(right);
    root->right = invertTree(left);
    
    return root;
}