public class Solution {
    public int BitwiseComplement(int num) {
        if (num == 0) {
            return 1;
        }
        
        var mask = 0xFFFFFFFF;
        while ((num & mask) > 0) {
            mask <<= 1;
        }
        
        return (int) (~num ^ mask);
    }
}