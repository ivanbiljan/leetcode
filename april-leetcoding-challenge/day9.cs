public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var priorities = new int[26];
        for (var i = 0; i < order.Length; ++i) {
            priorities[order[i] - 'a'] = i;
        }
        
        for (var i = 0; i < words.Length - 1; ++i) {
            if (Compare(words[i], words[i + 1], priorities) > 0) {
                return false;
            }
        }
        
        return true;
    }
    
    private int Compare(string a, string b, int[] priorities) {
        for (var i = 0; i < Math.Min(a.Length, b.Length); ++i) {
            if (priorities[a[i] - 'a'] < priorities[b[i] - 'a']) {
                return -1;
            }
            
            if (priorities[a[i] - 'a'] > priorities[b[i] - 'a']) {
                return 1;
            }
        }
        
        return a.Length - b.Length;
    }
}