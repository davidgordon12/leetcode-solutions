public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right) {
           int val = left + ((right-left) / 2);

           if(nums[val] < target) {
               left = val+1;
           }
           if(nums[val] > target) {
               right = val-1;
           }
           if(nums[val] == target) {
               return val;
           }
        }

        return -1;
    }
}