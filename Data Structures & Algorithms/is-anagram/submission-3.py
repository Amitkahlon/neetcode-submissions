class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): return False

        arr_s = [0 for _ in range(26)]
        arr_t = [0 for _ in range(26)]

        for c in s:
            arr_s[ord(c) - ord('a')] += 1
        
        for c in t:
            arr_t[ord(c) - ord('a')] += 1
        
        for i in range(24):
            if arr_s[i] != arr_t[i]:
                return False
            
        return True

        

