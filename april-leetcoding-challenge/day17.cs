public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        for (var i = 0; i < matrix.Length; ++i) {
            for (var j = 1; j < matrix[0].Length; ++j) {
                matrix[i][j] += matrix[i][j - 1];
            }
        }
        
        var ans = 0;
        for (var i = 0; i < matrix[0].Length; ++i) {
            for (var j = i; j < matrix[0].Length; ++j) {
                for (var k = 0; k < matrix.Length; ++k) {
                    var sum = 0;
                    for (var l = k; l < matrix.Length; ++l) {
                        sum += matrix[l][j] - (i > 0 ? matrix[l][i - 1] : 0);
                        if (sum == target) {
                            ++ans;
                        }
                    }
                }
            }
        }
        
        return ans;
    }
}