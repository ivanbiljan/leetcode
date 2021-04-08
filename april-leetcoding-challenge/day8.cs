public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var results = new List<string>();
        if (string.IsNullOrWhiteSpace(digits)) {
            return results;
        }
        
        var builder = new StringBuilder();
        var map = new List<string> {" ", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        /*foreach (var letter in map[digits[0]]) {
            Dfs(digits, 0, map, builder, results);
        }*/
        
        Dfs(digits, 0, map, builder, results);
        return results;
    }
    
    public void Dfs(
        string digits, 
        int currentIndex,
        List<string> map, 
        StringBuilder builder, 
        IList<string> results)
    {
        if (currentIndex == digits.Length) {
            if (builder.Length > 0) {
                results.Add(builder.ToString());
            }
            
            return;
        }
        
        foreach (var letter in map[digits[currentIndex] - '0']) {
            builder.Append(letter);
            Dfs(digits, currentIndex + 1, map, builder, results);
            builder.Remove(builder.Length - 1, 1);
        }
    }
}