public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> duplicates = new();
        int left = 0;
        int right = 0;
        while(right < nums.Length) {
            // we have seen this number before, skip it, we don't care about it
            if(duplicates.Contains(nums[right]))
                right++;
            else {
                duplicates.Add(nums[right]);
                nums[left] = nums[right];
                right++;
                left++;
            }
        }

        return left;
    }
}