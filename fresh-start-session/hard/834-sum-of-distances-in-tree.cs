public class Solution {
    private readonly Dictionary<int, List<int>> _graph = new();
    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        if (edges.Length == 0) {
            return new int[n];
        }

        foreach (var edge in edges) {
            var u = _graph.GetValueOrDefault(edge[0], new List<int>());
            var v = _graph.GetValueOrDefault(edge[1], new List<int>());

            u.Add(edge[1]);
            v.Add(edge[0]);
            _graph[edge[0]] = u;
            _graph[edge[1]] = v;
        }

        var count = new int[n];
        var ans = new int[n];
        Dfs(0, -1, count, ans);
        Dfs2(0, -1, count, ans);

        return ans;
    }

    private void Dfs(int root, int parent, int[] count, int[] ans) {
        count[root] = 1;
        foreach (int child in _graph[root]) {
            if (child != parent) {
                Dfs(child, root, count, ans);
                count[root] += count[child];
                ans[root] += ans[child] + count[child];
            }
        }
    }

    private void Dfs2(int root, int parent, int[] count, int[] ans) {
        foreach (int child in _graph[root]) {
            if (child != parent) {
                ans[child] = ans[root] - count[child] + (count.Length - count[child]);
                Dfs2(child, root, count, ans);
            }
        }
    }
}