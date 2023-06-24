public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) return 0;

        HashSet<char> chars = new HashSet<char>();

        int max = 0;
        int left = 0;
        int right = 0;

        while(right < s.Length) {
            var current = s[right];

            if(chars.Contains(s[right])) {
                chars.Remove(s[left]);
                left++;
            }
            else {
                chars.Add(s[right]);
                max = Math.Max(chars.Count(), max);
                right++;
            }
        }

        return max;
    }
}