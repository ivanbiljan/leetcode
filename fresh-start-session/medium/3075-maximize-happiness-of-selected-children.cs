public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);

        var ans = 0L;
        for (var i = 0; i < k; ++i) {
            ans += Math.Max(happiness[happiness.Length - i - 1] - i, 0);
        }

        return ans;
    }
}