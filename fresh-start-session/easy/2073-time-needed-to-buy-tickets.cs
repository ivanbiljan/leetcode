public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        var ans = 0;
        for (var i = 0; i < tickets.Length; ++i) {
            if (i <= k) {
                ans += Math.Min(tickets[i], tickets[k]);
            } else {
                ans += Math.Min(tickets[i], tickets[k] - 1);
            }
        }

        return ans;
    }
}