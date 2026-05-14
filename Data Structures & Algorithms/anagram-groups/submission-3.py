class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = {}

        for s in strs:
            map = [0 for _ in range(26)]

            for c in s:
                map[ord(c) - ord('a')] += 1

            key = ""
            for charCount in map:
                key += chr(charCount) + ' '

            res.setdefault(key, []).append(s)
        
        
        return list(res.values())


