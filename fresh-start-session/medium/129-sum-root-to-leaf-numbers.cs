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
    public int SumNumbers(TreeNode root) {
        return Helper(root, 0);
    }

    public int Helper(TreeNode root, int currentSum) {
        if (root is null) {
            return 0;
        }

        currentSum = currentSum * 10 + root.val;
        if (root.left is null && root.right is null) {
            return currentSum;
        }

        return Helper(root.left, currentSum) + Helper(root.right, currentSum);
    }
}