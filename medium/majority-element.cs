public class Solution {
    public int MajorityElement(int[] nums) {
        var element = nums[0];
        var count = 1;
        for (var i = 1; i < nums.Length; ++i) {
            if (nums[i] == element) {
                ++count;
                continue;
            }
            
            if (--count < 0) {
                element = nums[i];
                count = 1;
            }
        }
        
        return element;
    }
}