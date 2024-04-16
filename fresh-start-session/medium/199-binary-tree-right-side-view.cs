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
    public IList<int> RightSideView(TreeNode root) {
        var ans = new List<int>();
        if (root is null) {
            return ans;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var numOfNodesAtLevel = queue.Count;
            for (var i = 0; i < numOfNodesAtLevel; ++i) {
                var current = queue.Dequeue();
                if (current is null) {
                    continue;
                }
                
                if (current.left is not null) {
                    queue.Enqueue(current.left);
                }

                if (current.right is not null) {
                    queue.Enqueue(current.right);
                }

                if (i == numOfNodesAtLevel - 1) {
                    ans.Add(current.val);
                }
            }
        }

        return ans;
    }
}