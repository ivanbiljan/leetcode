public class Solution {
    public int[] SortedSquares(int[] A) {
        var results = new int[A.Length];
        
        var start = 0;
        var end = A.Length - 1;
        var currentIndex = A.Length - 1;
        while (start <= end) {
            if (Math.Abs(A[end]) >= Math.Abs(A[start])) {
                results[currentIndex--] = (int) Math.Pow(A[end--], 2);
            } else {
                results[currentIndex--] = (int) Math.Pow(A[start++], 2);
            }
        }
        
        return results;
    }
}