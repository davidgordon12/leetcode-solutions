public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1) return new int[] { -1 };

        int biggest = 0;
        int max = -1;
        for(int i = arr.Length-1; i >= 0; i--) {
            biggest = Math.Max(max, arr[i]);
            arr[i] = max;
            max = biggest;
        }

        arr[arr.Length-1] = -1;
        return arr;
    }
}