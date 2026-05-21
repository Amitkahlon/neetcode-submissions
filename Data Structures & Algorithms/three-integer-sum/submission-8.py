class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        res = []

        i = 0
        while i < len(nums):
            l, r = i + 1, len(nums) - 1


            while l < r:
                sum = nums[i] + nums[r] + nums[l]

                if sum == 0:
                    res.append([nums[i], nums[l], nums[r]])
                    l += 1
                    r -= 1
                    while nums[l] == nums[l - 1] and l < r:
                        l += 1
                elif sum > 0:
                    r -= 1
                else:
                    l += 1
            
            i += 1
            
            while i < len(nums) and nums[i - 1] == nums[i]:
                i += 1
                
            

            
        
        return res



                

