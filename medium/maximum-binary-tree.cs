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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        var numsSpan = nums.AsSpan();
        return ConstructSubTree(numsSpan);
    }
    
    private TreeNode ConstructSubTree(Span<int> nums) {
        if (nums.Length == 0) {
            return null;
        }
        
        var maxNum = nums[0];
        var maxNumIndex = 0;
        for (var i = 0; i < nums.Length; ++i) {
            if (nums[i] > maxNum) {
                maxNum = nums[i];
                maxNumIndex = i;
            }
        }
        
        var rootNode = new TreeNode(maxNum);
        rootNode.left = ConstructSubTree(nums[0..maxNumIndex]);
        rootNode.right = ConstructSubTree(nums[(maxNumIndex + 1)..]);
        return rootNode;
    }
}