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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if (depth == 1) {
            return new TreeNode(val: val, left: root);
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            --depth;
            var countAtLevel = queue.Count;
            for (var i = 0; i < countAtLevel; ++i) {
                var current = queue.Dequeue();
                if (current is null) {
                    continue;
                }

                if (depth - 1 > 0) {
                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);

                    continue;
                }

                var oldLeft = current.left;
                var oldRight = current.right;

                current.left = new TreeNode(val: val, left: oldLeft);
                current.right = new TreeNode(val: val, right: oldRight);
            }
        }

        return root;
    }
}