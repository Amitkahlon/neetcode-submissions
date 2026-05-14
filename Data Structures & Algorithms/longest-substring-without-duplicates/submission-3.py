class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) == 0: return 0

        is_char_exists = set()

        l = 0
        r = 1
        max_length = 1

        is_char_exists.add(s[l])

        while l <= r and r < len(s):

            while l <= r and r < len(s) and s[r] in is_char_exists:
                is_char_exists.remove(s[l])
                l += 1
            
            is_char_exists.add(s[r])

            max_length = max(max_length, r - l + 1)
            r += 1
        

        return max_length
            
