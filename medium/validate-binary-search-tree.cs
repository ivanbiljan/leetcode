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
    public bool IsValidBST(TreeNode root) {
        var stack = new List<int>();
        if (root == null) {
            return true;
        }
        
        Helper(root, stack);
        for (var i = 1; i < stack.Count; ++i) {
            if (stack[i - 1] >= stack[i]) {
                return false;
            }
        }
        
        return true;
    }
    
    public void Helper(TreeNode root, List<int> stack) {
        if (root == null) {
            return;
        }
        
        Helper(root.left, stack);
        stack.Add(root.val);
        Helper(root.right, stack);
    }
}