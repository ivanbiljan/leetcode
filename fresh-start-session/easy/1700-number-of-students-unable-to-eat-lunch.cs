public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int square = 0, circle = 0;
        foreach (var student in students) {
            if (student == 0) {
                square++;
            } else {
                circle++;
            }
        }

        for (var i = 0; i < sandwiches.Length; ++i) {
            if (sandwiches[i] == 0 && square == 0 || sandwiches[i] == 1 && circle == 0) {
                return sandwiches.Length - i;
            }

            if (sandwiches[i] == 0) {
                if (square-- == 0) {
                    return sandwiches.Length - i;
                }
            }

            if (sandwiches[i] == 1) {
                if (circle-- == 0) {
                    return sandwiches.Length - i;
                }
            }
        }

        return 0;
    }
}