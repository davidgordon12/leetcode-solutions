public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        int left = 0;
        int right = 0;

        while(right < nums.Length) {
            // keep walking until we hit a number
            if(nums[right] == 0) 
            {
                right++;
                continue;
            }

            /* swap left and right */
            int temp = nums[left];  // redundant since we are always moving 0
            nums[left] = nums[right];
            nums[right] = temp;     // nums[right] = 0;

            left++;
            right++;
        }
    }
}