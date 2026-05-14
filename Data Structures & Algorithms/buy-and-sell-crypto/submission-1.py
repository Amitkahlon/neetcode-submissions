class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        l = 0
        r = 1
        maxProfit = 0

        while r < len(prices):
            currProfit = prices[r] - prices[l]
            maxProfit = max(currProfit, maxProfit)

            if prices[r] < prices[l]:
                l = r

            r += 1

        return maxProfit