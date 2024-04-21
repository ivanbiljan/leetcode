public class Solution {
    // private readonly Dictionary<int, List<int>> graph = new();
    // private readonly List<int> visited = new();
    private readonly Dictionary<int, int> parent = new();

    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        // foreach (var edge in edges) {
        //     var verticesFirst = graph.GetValueOrDefault(edge[0], new List<int>());
        //     var verticesSecond = graph.GetValueOrDefault(edge[1], new List<int>());

        //     verticesFirst.Add(edge[1]);
        //     verticesSecond.Add(edge[0]);

        //     graph[edge[0]] = verticesFirst;
        //     graph[edge[1]] = verticesSecond;
        // }

        // DFS throws stack overfow on test case 24 safćlćqlčwrćčlćqčlfsqa
        // var queue = new Queue<int>();
        // queue.Enqueue(source);
        // while (queue.Count > 0) {
        //     var current = queue.Dequeue();
        //     visited.Add(current);
        //     if (current == destination) {
        //         return true;
        //     }

        //     foreach (var connectedVertex in graph[current]) {
        //         if (!visited.Contains(connectedVertex)) {
        //             queue.Enqueue(connectedVertex);
        //         }
        //     }
        // }

        for (var i = 0; i < n; ++i) {
            parent[i] = i;
        }

        foreach (var edge in edges) {
            var u = FindParent(edge[0]);
            var v = FindParent(edge[1]);
            parent[v] = u;
        }

        return FindParent(source) == FindParent(destination);
    }

    private int FindParent(int vertex) {
        if (vertex == parent[vertex]) {
            return vertex;
        }

        var newParent = FindParent(parent[vertex]);
        parent[vertex] = newParent;
        return newParent;
    }
}