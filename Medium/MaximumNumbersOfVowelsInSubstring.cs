public class Solution {
    public int MaxVowels(string s, int k) {
        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        var map = new Dictionary<char, int>();

        int max = 0;
        int left = 0;
        int right = 0;

        while(right < s.Length) {
            int count = 0;

            if(map.ContainsKey(s[right])) {
                map[s[right]]++;
            }
            else {
                map.Add(s[right], 1);
            }

            if((right-left) + 1 > k) {
                map[s[left]]--;
                left++;
            }

            foreach(var entry in map) {
                if(vowels.Contains(entry.Key)) {
                    count += entry.Value;
                }
            }

            right++;

            max = Math.Max(max, count);
        }

        return max;
    }
}
