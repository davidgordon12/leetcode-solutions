public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var res = new List<IList<int>>();

        Array.Sort(nums);

        for(int start = 0; start < nums.Length; start++) {
            int left = start+1;
            int right = nums.Length - 1;
            if(start != 0 && nums[start-1] == nums[start]) continue;

            while(left < right) {
                int sum = nums[start] + nums[left] + nums[right];
                if(sum == 0) {
                    res.Add(new List<int> { nums[start], nums[left], nums[right] } );
                    while(left < right && nums[left] == nums[left+1]) left++;
                    while(left < right && nums[right] == nums[right-1]) right--;
                    left++;
                }
                else if(sum > 0) {
                    right--;
                }
                else if(sum < 0) {
                    left++;
                }
            }
        }

        return res;
    }
}