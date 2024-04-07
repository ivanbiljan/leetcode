public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (flowerbed.Length == 1) {
            return n == 0 || n == 1 && flowerbed[0] == 0;
        }
        
        if (flowerbed.Length / 2 < n - 1) {
            return false;
        }
        
        for (var i = 0; i < flowerbed.Length; ++i) {
            if (flowerbed[i] == 0 && IsValid(flowerbed, i)) {
                flowerbed[i] = 1;
                --n;
                ++i;
            }
        }
        
        return n <= 0;
    }
    
    private bool IsValid(int[] n, int i) {
        if (i == 0) {
            return n[i + 1] == 0 && n[i] == 0;
        }
        
        if (i == n.Length - 1) {
            return n[n.Length - 2] == 0 && n[i] == 0;
        }
        
        return n[i - 1] == 0 && n[i + 1] == 0;
    }
}