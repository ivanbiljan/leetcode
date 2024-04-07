public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var ans = new List<bool>();
        var max = candies.Max();
        for (var i = 0; i < candies.Length; ++i) {
            ans.Add(candies[i] + extraCandies >= max);
        }

        return ans;
    }
}