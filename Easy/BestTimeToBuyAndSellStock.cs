public class Solution {
    public int MaxProfit(int[] prices) {
        int smallest = int.MaxValue;
        int mostProfit = 0;
        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < smallest) 
                smallest = prices[i];
            else {
                mostProfit = Math.Max(prices[i]-smallest, mostProfit); 
            }
        }

        return mostProfit;
    }
}