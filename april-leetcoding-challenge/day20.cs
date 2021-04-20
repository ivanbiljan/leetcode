/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        var ans = new List<int>();
        //Helper(root, ans); -- Recursive
        
        var stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0) {
            var node = stack.Pop();
            if (node == null) {
                continue;
            }
            
            ans.Add(node.val);
            for (var i = node.children.Count - 1; i >= 0; --i) {
                stack.Push(node.children[i]);
            }
        }
        
        return ans;
    }
    
    private void Helper(Node root, IList<int> ans) {
        if (root == null) {
            return;
        }
        
        ans.Add(root.val);
        foreach (var child in root.children) {
            Helper(child, ans);
        }
    }
}