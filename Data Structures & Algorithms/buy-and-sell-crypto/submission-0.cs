public class Solution {
            public int MaxProfit(int[] prices)
        {
            int l = 0; int r = 1;
            int maxProfit = 0;

            while (r < prices.Length)
            {
                int buy = prices[l];
                int sell = prices[r];
                int profit = sell - buy;

                if (buy < sell)
                {
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    l = r;
                }

                r++;
            }

            return maxProfit;
        }
}