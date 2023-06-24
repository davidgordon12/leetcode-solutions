public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var firstWord = strs[0];
        int strLen = firstWord.Length;

        foreach(var word in strs) {
            int subLen = 0;
            for(int i = 0; i < word.Length; i++) {
                if(subLen >= strLen || word[i] != firstWord[i]) break;
                subLen+=1;
            }
            strLen = Math.Min(strLen, subLen);
        }

        return firstWord.Substring(0, strLen);
    }
}