class Solution:

    def encode(self, strs: List[str]) -> str:
        res = ""
        for s in strs:
            res += f'{len(s)},'
        
        res = res[:-1]
        res += ":"

        for s in strs:
            res += s

        return res


    def decode(self, s: str) -> List[str]:
        if s == ":":
            return []


        tmp = s.split(':')
        lengths = tmp[0].split(",")
        if len(lengths) == 0:
            return []
        i = 0

        while s[i] != ':':
            i += 1
        
        i += 1

        res = []
        
        print(s)

        for strLength in lengths:
            l = int(strLength)
            currWord = ''
            for _ in range(l):
                currWord += s[i]
                i += 1
            res.append(currWord)
        

        return res

