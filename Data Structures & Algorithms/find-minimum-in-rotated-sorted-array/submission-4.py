class Solution:
    def findMin(self, nums: List[int]) -> int:
        l, r = 0, len(nums) - 1

        while l < r:
            if nums[l] < nums[r]: return nums[l] #this part of the array is sorted
            mid = (r + l) // 2
            if nums[mid] >= nums[l]:
                l = mid + 1
            else:
                r = mid
        
        return nums[l]