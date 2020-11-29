// Time complexity: O(n)
// Space complexity: O(1)
int binaryGap(int n) {
    if (n == 0 || n == 1) {
        return 0;
    }
    
    int distance = 0;
    int largestDistance = 0;
    int foundOne = n & 1;
    if (foundOne == 1) {
        distance = 1;
    }
    
    while ((n >>= 1) > 0) {
        int currentBit = n & 1;
        if (currentBit == 1) {
            if (distance > largestDistance) {
                largestDistance = distance;
            }
            
            distance = 1;
            foundOne = 1;
        } else { 
            if (foundOne == 1) {
                ++distance;
            }
        }
    }
    
    return largestDistance;
}