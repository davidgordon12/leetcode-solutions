public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> missing = new HashSet<int>();
        List<int> result = new List<int>();

        foreach(int num in nums) {
            missing.Add(num);
        }

        int range = nums.Length;
        for(int i = 1; i <= range; i++) {
            if(!missing.Contains(i)) {
                result.Add(i);
            }
        }

        return result;
    }
}