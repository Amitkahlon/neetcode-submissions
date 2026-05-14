from typing import List


class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        pre = [1] * len(nums)
        post = [1] * len(nums)
        res = [0] * len(nums)

        total = 1
        for i in range(len(nums)):
            if i == 0: continue
            total *= nums[i - 1]
            pre[i] = total

        total = 1
        for i in range(len(nums) - 2, -1, -1):
            total *= nums[i + 1]
            post[i] = total


        for i in range(len(nums)):
            res[i] = pre[i] * post[i]

        print(post)
        print(pre)
        return res





