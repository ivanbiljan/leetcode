public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        foreach (var layer in wall) {
            for (var i = 1; i < layer.Count; ++i) {
                layer[i] += layer[i - 1];
            }
        }
        
        var map = new Dictionary<int, int>();
        foreach (var layer in wall) {
            for (var i = 0; i < layer.Count - 1; ++i) {
                var val = layer[i];
                if (map.ContainsKey(val)) {
                    ++map[val];
                }
                else {
                    map[val] = 1;
                }
            }
        }
        
        var ans = wall.Count - (map.Values.Count > 0 ? map.Values.Max() : 0);
        return ans;
    }
}