public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        var ans = 0;
        var complements = new int[60];
        foreach (var t in time) {
            ans += complements[(60 - (t % 60)) % 60];
            complements[t % 60]++;
        }
        
        return ans;
    }
}