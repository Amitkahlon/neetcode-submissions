class Solution {
 public int maxProfit(int[] prices) {
        if(prices.length == 1) {
            return 0;
        }

        int i = 0;
        int j = 1;

        int maxProf = 0;

        while(j < prices.length) {
          if(prices[j] < prices[i]) {
            i = j;
            j = j + 1;
            continue;
          }

            int currProf = prices[j] - prices[i];

            maxProf = Math.max(maxProf, currProf);
            j++;
        }

        return maxProf;

    }
}
