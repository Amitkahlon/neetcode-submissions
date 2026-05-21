class Solution:
    def trap(self, height: List[int]) -> int:
        maxHeightLeft = [0] * len(height)
        maxHeightRight = [0] * len(height)
        sum = 0

        maxLeft = 0
        for i in range(len(height)):
            maxHeightLeft[i] = maxLeft
            maxLeft = max(height[i], maxLeft)
        
        maxRight = 0
        for i in range(len(height) - 1, -1, -1):
            print(i)
            maxHeightRight[i] = maxRight
            maxRight = max(maxRight, height[i])
        

        for i in range(1, len(height) - 1):
            total = min(maxHeightLeft[i], maxHeightRight[i]) - height[i]
            if total > 0:
                sum += total
        

        return sum



