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
        return SumInner(root, false);
    }

    public int SumInner(TreeNode root, bool isLeftSide) {
        if (root is null) {
            return 0;
        }

        if (isLeftSide && root.left is null && root.right is null) {
            return root.val;
        }

        return SumInner(root.left, true) + SumInner(root.right, false);
    }
}