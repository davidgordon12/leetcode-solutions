public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> remainder_index = new();
        int total = 0;

        remainder_index[0] = -1;

        for(int i = 0; i < nums.Length; i++) {
            total += nums[i];
            int remainder = total % k;
            if(remainder_index.ContainsKey(remainder)) {
                if(i - remainder_index[remainder] >= 2) {
                    return true;
                }
            }
            else {
                remainder_index.Add(remainder, i);
            }
        }

        return false;
    }
}