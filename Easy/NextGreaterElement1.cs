public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        Dictionary<int, int> elements = new Dictionary<int, int>();

        for(int idx = 0; idx < nums1.Length; idx++) {
            elements.Add(nums1[idx], idx);
            result[idx] = -1;
        }

        for(int i = 0; i < nums2.Length; i++) {
            if(elements.ContainsKey(nums2[i])) {
                for(int j = i+1; j < nums2.Length; j++) {
                    if(nums2[j] > nums2[i]) {
                        result[elements[nums2[i]]] = nums2[j];
                        break;
                    }
                }
            }
        }

        return result;
    }
}