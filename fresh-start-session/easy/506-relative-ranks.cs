public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var pq = new PriorityQueue<int, int>();
        for (var i = 0; i < score.Length; ++i) {
            pq.Enqueue(i, score[i]);
        }

        var ans = new string[score.Length];
        while (pq.Count > 0) {
            var ix = pq.Count - 1;
            var el = pq.Dequeue();
            ans[el] = ix switch {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (ix + 1).ToString()
            };
        }

        return ans;
    }
}