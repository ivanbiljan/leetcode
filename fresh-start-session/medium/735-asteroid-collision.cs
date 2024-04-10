public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        foreach (var asteroid in asteroids) {
            if (asteroid >= 0 || asteroid < 0 && (stack.Count == 0 || stack.Peek() < 0)) {
                stack.Push(asteroid);
                continue;
            }

            while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -asteroid) {
                stack.Pop();
            }

            if (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() == -asteroid) {
                stack.Pop();
            } else if (stack.Count == 0 || stack.Count > 0 && stack.Peek() < 0) {
                stack.Push(asteroid);
            }
        }

        var ans = new int[stack.Count];
        while (stack.Count > 0) {
            ans[stack.Count - 1] = stack.Pop();
        }

        return ans;
    }
}