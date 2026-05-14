class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        pre_arr = [0] * len(nums)
        post_arr = [0] * len(nums)
        result = [0] * len(nums)

        for i in range(len(nums)):
            pre = 1
            post = 1

            for j in range(0, i):
                pre *= nums[j]
           
            for j in range(i + 1, len(nums)):
                post *= nums[j]
            
            pre_arr[i] = pre
            post_arr[i] = post

        for i in range(len(result)):
            result[i] = pre_arr[i] * post_arr[i]

        return result
            


            