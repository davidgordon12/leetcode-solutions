public class Solution {
    public int MaxVowels(string s, int k) {
        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        
        int left = 0;
        int right = 0;
        int count = 0;
        int max = 0;

        while(right < s.Length) {
            if(vowels.Contains(s[right])) {
                count++;
            }

            if((right-left)+1 > k) {
                if(vowels.Contains(s[left])) {
                    count--;
                }
                left++;
            }

            max = Math.Max(max, count);
            right++;
        }

        return max;
    }
}
