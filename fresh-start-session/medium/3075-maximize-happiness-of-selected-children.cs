public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        // Array.Sort(happiness);

        // var ans = 0L;
        // for (var i = 0; i < k; ++i) {
        //     ans += Math.Max(happiness[happiness.Length - i - 1] - i, 0);
        // }

        // return ans;

        var heap = new PriorityQueue<int, int>(new MaxHeapComparer());
        foreach (var h in happiness) {
            heap.Enqueue(h, h);
        }

        var ans = 0L;
        for (var i = 0; i < k; ++i) {
            ans += Math.Max(heap.Dequeue() - i, 0);
        }

        return ans;
    }
}

public sealed class MaxHeapComparer : IComparer<int> {
    public int Compare(int x, int y) => y.CompareTo(x);
}