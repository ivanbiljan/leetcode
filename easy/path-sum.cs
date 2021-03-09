/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        return Helper(root, sum);
    }
    
    public bool Helper(TreeNode root, int currentSum) {
        if (root == null) {
            return false;
        }
        
        if (root.left == null && root.right == null) {
            return currentSum - root.val == 0;
        }
        
        return Helper(root.left, currentSum - root.val) || Helper(root.right, currentSum - root.val);
    }
}