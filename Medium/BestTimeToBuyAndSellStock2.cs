public class Solution {
    public int MaxProfit(int[] prices) {
        int total = 0;
        int smallest = int.MaxValue;

        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < smallest) {
                smallest = prices[i];
            } 
            else {
                total += prices[i] - smallest;
                smallest = int.MaxValue;
                i--;
            }
        }

        return total;
    }
}