public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0;
        int rightSum = 0;
        int total = nums.Sum();

        for(int i = 0; i<nums.Length; i++) {
            rightSum = total - nums[i] - leftSum;

            if(leftSum == rightSum)
                return i;
            
            leftSum += nums[i];
        }

        return -1;
    }
}