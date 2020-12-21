/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return Helper(root);
    }
    
    public int Helper(TreeNode root, bool isLeft = false) {
        if (root == null) {
            return 0;
        }
        
        if (isLeft && root.left == null && root.right == null) {
            return root.val;
        }
        
        
        int sum = Helper(root.left, true);
        if (root.right != null)
            sum += Helper(root.right, false);
        
        return sum;
    }
}