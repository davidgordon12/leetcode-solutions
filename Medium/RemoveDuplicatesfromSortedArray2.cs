public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var map = new Dictionary<int, int>();

        int dups = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(!map.ContainsKey(nums[i])) {
                map.Add(nums[i], 1);
            } 
            else {
                map[nums[i]]++;
            }

            if(map[nums[i]] > 1) {
                    int idx = i;
                    while(idx+1 < nums.Length && nums[idx] == nums[idx+1]) {
                        int temp = nums[idx];
                        nums[idx] = nums[idx+1];
                        nums[idx+1] = temp;
                        idx++;
                    }
                    
                    dups++;
                }
        }

        return nums.Length - dups;
    }
}
