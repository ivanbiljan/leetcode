public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        var pq = new PriorityQueue<(int, int), double>();
        for (var i = 0; i < arr.Length - 1; ++i) {
            for (var j = arr.Length - 1; j >= i + 1; --j) {
                pq.Enqueue((arr[i], arr[j]), (double) arr[i] / arr[j]);
            }
        }

        var ix = 0;
        while (k - 1 > 0) {
            pq.Dequeue();
            --k;
        }

        var (first, second) = pq.Dequeue();
        return new int[] {first, second};
    }
}