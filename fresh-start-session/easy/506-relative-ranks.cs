public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var pq = new PriorityQueue<int, int>();
        for (var i = 0; i < score.Length; ++i) {
            pq.Enqueue(i, score[i]);
        }

        var ans = new string[score.Length];
        while (pq.Count > 0) {
            var count = pq.Count;
            var el = pq.Dequeue();
            ans[el] = count switch {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => count.ToString()
            };
        }

        return ans;
    }
}