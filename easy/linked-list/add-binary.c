// Time complexity: O(n)
// Space complexity: O(n)
char* addBinary(char* a, char* b){
    int lenA = strlen(a);
    int lenB = strlen(b);    
    int finalLength = (lenA > lenB ? lenA : lenB) + 2;
    char* sum = malloc(finalLength * sizeof(char)); // Accomodate space for the final carry and the null terminator
    sum[finalLength - 1] = '\0';
    
    int carry = 0;
    int currentChar = finalLength - 2;
    while (lenA - 1 >= 0 || lenB - 1 >= 0) {
        int aBit = lenA - 1 >= 0 && a[lenA - 1] == '1';
        int bBit = lenB - 1 >= 0 && b[lenB - 1] == '1';
        
        sum[currentChar--] = (aBit ^ bBit) ^ carry ? '1' : '0';
        carry = (aBit & bBit) | ((aBit ^ bBit) & carry);
        --lenA;
        --lenB;
    }
    
    if (carry) {
        sum[0] = '1';
        return sum;
    }
    
    return sum + 1;
}