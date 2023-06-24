public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int left = 0;
        int right = 0;

        HashSet<int> dups = new();

        while(right < nums.Length) {
            if(dups.Contains(nums[right])) {
                return true;
            }
            else {
                dups.Add(nums[right]);
            }

            if(right >= k) {
                dups.Remove(nums[left]);
                left++;
            }

            right++;
        }

        return false;
    }
}