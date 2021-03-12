public class Solution {
	public bool IsUnique(string input) {
		// O(n) time, O(1) space
		/*var set = new HashSet<int>();
		foreach (var character in input) {
			if (set.Contains(character)) {
				return false;
			}

			set.Add(character);
		}

		return true;*/

		// O(n) time, O(1) space, no additional data structures
		 var vector = 0;
		 foreach (var character in input) {
			 if ((vector & 1 << (character - 'a')) != 0) {
				 return false;
			 }

			 vector |= 1 << (character - 'a');
		 }

		 return true;
	}
}