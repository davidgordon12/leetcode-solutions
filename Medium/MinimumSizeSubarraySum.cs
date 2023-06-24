public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int smallest = int.MaxValue;
        int left = 0; int right = 0;
        int total = 0;

        while(right < nums.Length) {
            total += nums[right];

            while(total >= target) {
                smallest = Math.Min(smallest, right-left+1);
                total -= nums[left];
                left++;
            }

            right++;
        }

        if(smallest > nums.Length)
            return 0;
        else
            return smallest;
    }
}