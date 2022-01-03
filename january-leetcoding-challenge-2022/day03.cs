public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var degrees = new int[n];
        
        foreach (var pair in trust) {
            degrees[pair[0] - 1]--;
            degrees[pair[1] - 1]++;
        }
        
        for (var i = 0; i < degrees.Length; ++i) {
            if (degrees[i] == n - 1) {
                return i + 1;
            }
        }
        
        return -1;
    }
}