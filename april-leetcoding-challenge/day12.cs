public class Solution {
    public int[] ConstructArray(int n, int k) {
        // [1, 2, 3, 4]
        // [1, 4, 2, 3]
        
        // [1, 2, 3, 4, 5]
        // [1, 5, 2, 4, 3]
        
        // [1, 2, 3, 4, 5, 6]
        // [1, 6, 2, 5, 3, 4], k = 5
        // [1, 3, 2, 4, 5, 6], k = 2
        
        // [1, 2, 3, 4], k = 2
        
        var counter = 0;
        var start = 1;
        var end = k + 1;
        
        var result = new int[n];
        while (start < end) {
            result[counter++] = start++;
            result[counter++] = end--;
        }
        
        if (start == end) {
            result[counter++] = start;
        }
        
        for (; counter < n; ++counter) {
            result[counter] = counter + 1;
        }
        
        return result;
    }
}