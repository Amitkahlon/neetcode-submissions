class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        s_count = [0 for _ in range(26)]
        t_count = [0 for _ in range(26)]


        for c in s:
            index = ord(c) - ord('a')
            print(index)
            s_count[index] += 1
        

        for c in t:
            index = ord(c) - ord('a')
            t_count[index] += 1
        

        for i in range(26):
            if s_count[i] != t_count[i]:
                return False
            
        
        return True

        



        

