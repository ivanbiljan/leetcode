public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var sortedList = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (var i = 0; i < nums.Length; ++i) {
            if (sortedList.ContainsKey(nums[i])) {
                ++sortedList[nums[i]];
            } else {
                sortedList.Add(nums[i], 1);
            }
        }
        
        int numValues = 0;
        foreach (var kvp in sortedList) {
            numValues += kvp.Value;
            if (numValues >= k) {
                return kvp.Key;
            }
        }
        
        return -1;
    }
}