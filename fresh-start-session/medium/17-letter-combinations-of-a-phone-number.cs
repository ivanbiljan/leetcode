public class Solution {
    private static readonly Dictionary<char, char[]> Keypad = new() {
        ['2'] = new char[] {'a', 'b', 'c'},
        ['3'] = new char[] {'d', 'e', 'f'},
        ['4'] = new char[] {'g', 'h', 'i'},
        ['5'] = new char[] {'j', 'k', 'l'},
        ['6'] = new char[] {'m', 'n', 'o'},
        ['7'] = new char[] {'p', 'q', 'r', 's'},
        ['8'] = new char[] {'t', 'u', 'v'},
        ['9'] = new char[] {'w', 'x', 'y', 'z'}
    };

    public IList<string> LetterCombinations(string digits) {
        var ans = new List<string>();
        if (string.IsNullOrWhiteSpace(digits)) {
            return ans;
        }

        var digitsArray = digits.ToCharArray();
        ComputeCombinations(digitsArray, 0, new char[digits.Length], ans);

        return ans;        
    }

    public void ComputeCombinations(char[] digits, int ix, char[] currentCombo, List<string> ans) {
        if (ix == digits.Length) {
            ans.Add(new string(currentCombo));
            return;
        }

        foreach (var mappedLetter in Keypad[digits[ix]]) {
            currentCombo[ix] = mappedLetter;
            ComputeCombinations(digits, ix + 1, currentCombo, ans);
            currentCombo[ix] = default(char);
        }
    }
}