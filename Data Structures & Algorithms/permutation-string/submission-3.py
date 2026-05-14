from typing import List


class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:

        n = len(s1)

        if len(s1) > len(s2): return False
        
        if n == 1:
            return s1 in s2

        s1CharCount = [0] * 26
        s2CharCount = [0] * 26

        #setting up char count for s1
        for i in range(n):
            cIndex = ord(s1[i]) - ord("a")
            s1CharCount[cIndex] += 1


        for i in range(n):
            cIndex = ord(s2[i]) - ord("a")
            s2CharCount[cIndex] += 1

        i = 0
        j = n - 1

        while j < len(s2):
            if self.eq_charCount(s1CharCount, s2CharCount):
                return True

            if j + 1 >= len(s2): break

            iIndex = ord(s2[i]) - ord("a")
            s2CharCount[iIndex] -= 1

            i += 1
            j += 1

            jIndex = ord(s2[j]) - ord("a")
            s2CharCount[jIndex] += 1

        return False



    def eq_charCount(self, s1: List[int], s2: List[int]) -> bool:
        for i in range(26):
            if s1[i] != s2[i]: return False

        return True


