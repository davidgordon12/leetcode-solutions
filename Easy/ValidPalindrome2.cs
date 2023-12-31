public class Solution {
    public bool ValidPalindrome(string s) {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;
        while (leftPointer < rightPointer)
        {
            if (s[leftPointer] != s[rightPointer])
            {
                return IsPalindrome(s, leftPointer + 1, rightPointer) || IsPalindrome(s, leftPointer, rightPointer - 1);
            }
            leftPointer++;
            rightPointer--;
        }
        return true;
    }

    public bool IsPalindrome(string s, int left, int right) {
        while (left < right) {
            if(s[left] != s[right]) return false;
            left++;
            right--;
        }

        return true;
    }
}