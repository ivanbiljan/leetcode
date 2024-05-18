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
    public int DistributeCoins(TreeNode root) {
        var ans = 0;
        Helper(root, ref ans);
        return ans;
    }

    private int Helper(TreeNode root, ref int ans) {
        if (root is null) {
            return 0;
        }
        
        var left = Helper(root.left, ref ans);
        var right = Helper(root.right, ref ans);
        ans += Math.Abs(left) + Math.Abs(right);

        return root.val - 1 + left + right;
    }
}