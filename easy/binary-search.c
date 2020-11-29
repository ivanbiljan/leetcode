int search(int* nums, int numsSize, int target){
    if (numsSize == 0) {
        return -1;
    }
    
    int low = 0;
    int high = numsSize - 1;
    int mid = (high - low) / 2;
    while (low <= high) {
        if (nums[mid] == target) {
            return mid;
        } else if (nums[mid] < target) {
            low = mid + 1;
        } else {
            high = mid - 1;
        }
        
        mid = low + (high - low) / 2;
    }
    
    return -1;
}