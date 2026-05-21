class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefix = [1] * (len(nums))
        postfix = [1] * (len(nums))


        pre = 1

        for i in range(len(nums)):
            prefix[i] = pre * nums[i]
            pre *= nums[i]
        
        post = 1

        for i in range(len(nums) -1, -1, -1):
            postfix[i] = post * nums[i]
            post *= nums[i]

        res = []

        for i in range(len(nums)):
            if i == 0:
                res.append(postfix[i + 1])
            elif i == len(nums) - 1:
                res.append(prefix[i - 1])
            else:
                res.append(prefix[i - 1] * postfix[i + 1])
        
        print(prefix)
        print(postfix)

        return res

                


            