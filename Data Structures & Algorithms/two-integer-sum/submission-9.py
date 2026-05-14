class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        new_sum = [(n, i) for i, n in enumerate(nums)]
        new_sum.sort()
        l, r = 0, len(new_sum) - 1

        while l < r:
            left_item = new_sum[l][0]
            right_item = new_sum[r][0]
            two_sum = left_item + right_item


            if two_sum == target:
                return sorted([new_sum[l][1], new_sum[r][1]])
            
            elif two_sum < target:
                l += 1
            else:
                r -= 1