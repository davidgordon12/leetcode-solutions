public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int, int> basket = new Dictionary<int, int>();

        int left = 0;
        int right = 0;
        int max = 0;
        int count = 0;

        while(right < fruits.Length) {
            if(basket.ContainsKey(fruits[right])) {
                basket[fruits[right]]++;
            }
            else {
                basket.Add(fruits[right], 1);
            }

            count++;

            while(basket.Count > 2) {
                basket[fruits[left]]--;
                count--;

                if(basket[fruits[left]] == 0) {
                    basket.Remove(fruits[left]);
                }
                
                left++;
            }

            max = Math.Max(max, count);

            right++;
        }

        return max;
    }
}
