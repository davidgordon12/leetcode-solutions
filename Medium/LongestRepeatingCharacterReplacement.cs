public class Solution {
    public int CharacterReplacement(string s, int k) {
        int max = 0, left = 0, right = 0;
        var frequency = new Dictionary<char, int>();

        while(right < s.Length) {
            var current = s[right];
            if(frequency.ContainsKey(current))
                frequency[current]++;
            else
                frequency.Add(current, 1);

            right++;
            
            if((right-left) - frequency.MaxBy(kvp => kvp.Value).Value > k) {
                frequency[s[left]]--;
                left++;
            }

            max = Math.Max(max, right-left);
        }

        return max;
    }
}