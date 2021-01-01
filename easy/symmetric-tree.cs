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
    public bool IsSymmetric(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var firstNode = queue.Dequeue();
            var secondNode = queue.Dequeue();
            if (firstNode == null && secondNode == null) {
                continue;
            }
            
            if (firstNode == null && secondNode != null || firstNode != null && secondNode == null) {
                return false;
            }
            
            if (firstNode.left != null && secondNode.right == null || firstNode.left == null && secondNode.right != null) {
                return false;
            }
            
            if (firstNode.right != null && secondNode.left == null || firstNode.right == null && secondNode.left != null) {
                return false;
            }
            
            if (firstNode.left?.val != secondNode.right?.val) {
                return false;
            }
            
            if (firstNode.right?.val != secondNode.left?.val) {
                return false;
            }
            
            queue.Enqueue(firstNode.left);
            queue.Enqueue(secondNode.right);
            queue.Enqueue(firstNode.right);
            queue.Enqueue(secondNode.left);
        }
        
        return true;
    }
}
