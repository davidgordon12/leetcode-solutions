public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> sequence = new HashSet<int>(nums);
        int max = 0;

        for(int i = 0; i < nums.Length; i++) {
            int val = nums[i];

            // if sequence contains val-1, then there is no point of counting
            // the greatest sequence from here, so we skip this index
            if(!sequence.Contains(val-1)) {
                int len = 0;
                while(sequence.Contains(val+len)) len++;

                max = Math.Max(max, len);
            }
        }

        return max;
    }
}