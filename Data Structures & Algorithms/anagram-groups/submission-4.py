class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        str_maps = {}

        for word in strs:
            c_count = [0] * 26
            for c in word:
                c_index = ord(c) - ord('a')
                c_count[c_index] += 1
            

            c_key = ""

            for count in c_count:
                c_key += str(count)
                c_key += " "
            

            if c_key not in str_maps:
                str_maps[c_key] = []
            
            str_maps[c_key].append(word)
        

        return list(str_maps.values())
        






