public class Solution {
    public void SortColors(int[] nums) {
        for(int i = 0; i < nums.Length; i++) {
            int val = nums[i];
            int prev = i-1;
            while(prev >= 0 && nums[prev] > val) {
                int temp = nums[prev];
                nums[prev] = nums[prev+1];
                nums[prev+1] = temp;

                prev--;
            }
        }
    }
}