class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        map = {} #key = string representing chars count of the word, value = string

        for currStr in strs:
            char_count = [0] * 26
            for c in currStr:
                c_value = ord(c) - ord('a')
                char_count[c_value]+= 1

            str_key = ",".join(str(n) for n in char_count)
            if str_key not in map:
                map[str_key] = []

            map[str_key].append(currStr)

        l = [list(x) for x in map.values()]
        return l
