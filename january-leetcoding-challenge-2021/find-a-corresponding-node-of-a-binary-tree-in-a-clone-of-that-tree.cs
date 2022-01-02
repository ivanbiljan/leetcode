/**
Given two binary trees original and cloned and given a reference to a node target in the original tree.

The cloned tree is a copy of the original tree.

Return a reference to the same node in the cloned tree.

Note that you are not allowed to change any of the two trees or the target node and the answer must be a reference to a node in the cloned tree.

Follow up: Solve the problem if repeated values on the tree are allowed.
*/

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
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        // Level order search
        var queue = new Queue<TreeNode>();
        queue.Enqueue(original);
        queue.Enqueue(cloned);
        while (queue.Count > 0) {
            var originalNode = queue.Dequeue();
            var clonedNode = queue.Dequeue();
            if (originalNode == target) {
                return clonedNode;
            }
            
            if (originalNode.left != null) {
                queue.Enqueue(originalNode.left);
                queue.Enqueue(clonedNode.left);
            }
            
            if (originalNode.right != null) {
                queue.Enqueue(originalNode.right);
                queue.Enqueue(clonedNode.right);
            }
        }
        
        return null;
    }
}