public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> chars = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++) {
            if(chars.ContainsKey(s[i])) {
                chars[s[i]]++;
            }
            else {
                chars.Add(s[i], 1);
            }

            if(chars.ContainsKey(t[i])) {
                chars[t[i]]--;
            }
            else {
                chars.Add(t[i], -1);
            }
        }

        foreach(var entry in chars) {
            if(entry.Value != 0) return false;
        }

        return true;
    }
}