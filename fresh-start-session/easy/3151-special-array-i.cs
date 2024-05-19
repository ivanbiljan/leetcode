public class Solution {
    public bool IsArraySpecial(int[] nums) {
        for (var i = 0; i < nums.Length - 1; ++i) {
            if (nums[i] % 2 == nums[i + 1] % 2) {
                return false;
            }
        }

        return true;
    }
}