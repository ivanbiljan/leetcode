public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // var prefix = new Dictionary<int, int>();
        // var suffix = new Dictionary<int, int>();

        // var productLeft = 1;
        // var productRight = 1;

        // for (int start = 0, end = nums.Length - 1; start < nums.Length; ++start, --end) {
        //     productLeft *= nums[start];
        //     prefix[start] = productLeft;

        //     productRight *= nums[end];
        //     suffix[end] = productRight;
        // }

        // var answer = new int[nums.Length];
        // answer[0] = suffix[1];
        // answer[nums.Length - 1] = prefix[nums.Length - 2];
        // for (var i = 1; i < nums.Length - 1; ++i) {
        //     answer[i] = prefix[i - 1] * suffix[i + 1];
        // }

        var prefix = nums[0];
        var suffix = nums[nums.Length - 1];

        var answer = new int[nums.Length];

        for (var i = 1; i < answer.Length - 1; ++i) {
            answer[i] = prefix;
            prefix *= nums[i];
        }

        answer[nums.Length - 1] = prefix;
        
        for (var i = answer.Length - 2; i > 0; --i) {
            answer[i] *= suffix;
            suffix *= nums[i];
        }

        answer[0] = suffix;

        return answer;
    }
}