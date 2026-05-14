class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        numSet = set()
        maxSequences = 0

        for num in nums:
            numSet.add(num)

        for num in nums:
            if num - 1 not in numSet: #check if start of sequence
                tmp = num + 1
                while tmp in numSet:
                    tmp += 1

                maxSequences = max(maxSequences, tmp - num)
                #reached the end of the sequence


        return maxSequences