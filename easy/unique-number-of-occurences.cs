public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < arr.Length; ++i) {
            if (!dict.ContainsKey(arr[i])) {
                dict[arr[i]] = 0;
                continue;
            }
            
            dict[arr[i]]++;
        }
        
        var set = new HashSet<int>(dict.Values);
        return set.Count == dict.Values.Count;
    }
}