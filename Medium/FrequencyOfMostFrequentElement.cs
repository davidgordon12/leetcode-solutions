public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        Array.Sort(nums);
        
        int left = 0, right = 0;
        var max = 0;
        long totalSum = 0;
        
        while(right < nums.Length){
            totalSum += nums[right];
            
            while(nums[right] * (right - left + 1) > totalSum + k) {
                totalSum -= nums[left];
                left++;
            }
            
            max = Math.Max((right - left + 1), max);
            right++;
        }
        
        return max;
    }
}