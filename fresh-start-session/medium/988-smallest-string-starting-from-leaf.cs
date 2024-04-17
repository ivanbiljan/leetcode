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
    public string SmallestFromLeaf(TreeNode root) {
        var ans = string.Empty;
        Helper(root, string.Empty, ref ans);

        return ans;
    }

    public void Helper(TreeNode root, string current, ref string ans) {
        if (root is null) {
            return;
        }

        var newString = (char)('a' + root.val) + current;
        if (root.left is null && root.right is null) {
            if (string.IsNullOrWhiteSpace(ans) || string.Compare(newString, ans) < 0) {
                ans = newString;
            }

            return;
        }

        Helper(root.left, newString, ref ans);
        Helper(root.right, newString, ref ans);
    }
}