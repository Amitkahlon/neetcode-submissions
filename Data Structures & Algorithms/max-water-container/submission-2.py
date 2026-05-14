class Solution:
    def maxArea(self, heights: List[int]) -> int:
        l, r = 0, len(heights) - 1

        max_sum = 0
        max_l = -1
        max_r = len(heights)

        while l < r:
            dis = r - l
            curr_sum = min(heights[l], heights[r]) * dis
            if max_sum < curr_sum:
                max_sum = curr_sum
                max_l = l
                max_r = r

            
            if heights[l] >= heights[r]:
                r -= 1
            else:
                l += 1
            
        
        return max_sum
            

