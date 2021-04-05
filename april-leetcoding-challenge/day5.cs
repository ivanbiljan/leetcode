public class Solution {
    public bool IsIdealPermutation(int[] A) {
        for (var i = 0; i < A.Length; ++i) {
            if (Math.Abs(i - A[i]) > 1) {
                return false;
            }
        }
        
        return true;
    }
}