[10,1,4,3,6,1, 7,1]

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        if len(prices) < 2:
            return 0
        
        max_price = 0
        

        l = 0
        r = 1


        while l < r and r < len(prices):
            if prices[l] > prices[r]:
                l = r
                r += 1
                continue
            
            max_price = max(max_price, prices[r] - prices[l])
            r += 1
        

        return max_price

            
            







            






            
