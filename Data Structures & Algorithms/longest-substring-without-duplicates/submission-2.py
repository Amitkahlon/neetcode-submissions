class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) == 0:
            return 0
        
        containChars = set()
        l = 0
        r = 1
        maxLength = 1
        containChars.add(s[l])

        while r < len(s):
            while r < len(s) and s[r] not in containChars:
                containChars.add(s[r])
                maxLength = max(maxLength, r - l + 1)
                r += 1

            while r < len(s) and l < r and s[r] in containChars :
                containChars.remove(s[l])
                l += 1

        return maxLength