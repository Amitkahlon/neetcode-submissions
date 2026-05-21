import heapq
from collections import defaultdict
from typing import List



class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        map = {}

        for n in nums:
            if n not in map:
                map[n] = 0
            
            map[n] += 1
        

        
        tmp = [(-count, num) for num, count in map.items()]
        heapq.heapify(tmp)

        res = []

        for i in range(k):
            top = heapq.heappop(tmp)[1]
            res.append(top)
        

        return res












