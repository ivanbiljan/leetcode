public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var collected = new HashSet<int>();
        Helper(rooms[0], collected);
        
        foreach (var room in rooms) {
            foreach (var key in room) {
                if (!collected.Contains(key)) {
                    return false;
                }
            }
        }
        
        return true;
        
       void Helper(IList<int> room, HashSet<int> collected) {
            foreach (var key in room) {
                if (collected.Contains(key)) {
                    continue;
                }
                
                collected.Add(key);
                Helper(rooms[key], collected);
            }
        }
    }
}