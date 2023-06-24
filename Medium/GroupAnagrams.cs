public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, IList<string>>();

        foreach(string str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if(groups.ContainsKey(key))
                groups[key].Add(str);
            else
                groups.Add(key, new List<string> { str } );
        }

        return groups.Values.ToList();
    }
}
