class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        l, r = 0, 0

        currSum = nums[0]
        minLength = len(nums) + 1

        while l <= r and r < len(nums):
            while currSum < target:
                r += 1
                if r >= len(nums):
                    break
                
                currSum += nums[r]
            
            
            while r < len(nums) and l <= r and currSum >= target:
                minLength = min(minLength, r - l + 1)
                currSum -= nums[l]
                l += 1
            

        if minLength == len(nums) + 1:
            return 0
        else:
            return minLength 


            

                

