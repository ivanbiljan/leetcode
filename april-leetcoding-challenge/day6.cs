public class Solution {
    public int MinOperations(int n) {
        if (n <= 1) {
            return 0;
        }
        
        var targetValue = (n / 2) * 2 + 1;
        if (n % 2 == 0) {
            targetValue = (targetValue + ((n - 1) / 2) * 2 + 1) / 2;
        }
        
        var numMoves = 0;
        for (var i = 0; i < n / 2; ++i) {
            numMoves += targetValue - (i * 2 + 1);
        }
        
        return numMoves;
    }
}