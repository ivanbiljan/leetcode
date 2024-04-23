public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        if (edges.Length == 0) {
            return [0];
        }

        if (n == 1) {
            return [];
        }

        var adjCount = new int[n];
        var graph = new Dictionary<int, List<int>>();
        foreach (var edge in edges) {
            var u = graph.GetValueOrDefault(edge[0], new List<int>());
            var v = graph.GetValueOrDefault(edge[1], new List<int>());

            u.Add(edge[1]);
            adjCount[edge[0]]++;
            v.Add(edge[0]);
            adjCount[edge[1]]++;

            graph[edge[0]] = u;
            graph[edge[1]] = v;
        }

        var queue = new Queue<int>();
        for (var i = 0; i < adjCount.Length; ++i) {
            if (adjCount[i] == 1) {
                queue.Enqueue(i);
            }
        }

        var unprocessedNodes = n;
        while (unprocessedNodes > 2) {
            var queueCount = queue.Count;
            for (var i = 0; i < queueCount; ++i) {
                var current = queue.Dequeue();
                foreach (var connectedVertex in graph[current]) {
                    if (--adjCount[connectedVertex] == 1) {
                        queue.Enqueue(connectedVertex);
                    }
                }
            }

            unprocessedNodes -= queueCount;
        }

        return queue.ToList();
    }
}