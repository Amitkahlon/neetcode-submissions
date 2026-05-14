class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        i = 0

        nums.sort()
        res = []

        print(nums)
        
        while i < len(nums) - 2:
            currentItem = nums[i]
            if i > 0 and currentItem == nums[i - 1]:
                i += 1
                continue

            j = i + 1
            z = len(nums) - 1

            while j < z:
                leftItem = nums[j]
                rightItem = nums[z]

                triplteSum = currentItem + rightItem + leftItem
                
                if triplteSum == 0:
                    res.append([currentItem, leftItem, rightItem])
                    z -= 1
                    j += 1
                    while nums[j] == nums[j - 1] and j < z:
                        j += 1
                elif triplteSum > 0:
                    z -= 1
                else:
                    j += 1
            i += 1
            


        return res                  