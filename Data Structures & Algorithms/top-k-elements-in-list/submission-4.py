import heapq
from collections import defaultdict
from typing import List



class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        hash_map = defaultdict(int)
        heap = []
        res = []

        for n in nums:
            hash_map[n] -= 1

        for n in hash_map:
            heapq.heappush(heap, (hash_map[n], n))

        for i in range(k):
            item = heapq.heappop(heap)
            res.append(item[1] )


        return res







