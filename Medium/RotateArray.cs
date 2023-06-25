public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            int idx = (i+k) % nums.Length;
            res[idx] = nums[i];
        }

        Array.Copy(res, nums, nums.Length);
    }
}
