class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        arr = [(num, i) for i, num in enumerate(nums)]
        arr.sort()
        l, r = 0, len(nums) - 1


        while l < r:
            num_l = arr[l][0]
            num_r = arr[r][0]

            if num_l + num_r == target:
                return sorted([arr[l][1], arr[r][1]])
            elif num_l + num_r > target:
                r -= 1
            else: 
                l += 1


        return -1 




