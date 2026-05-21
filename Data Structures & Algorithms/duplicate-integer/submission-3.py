class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        mymap = set()

        for n in nums:
            if not n in mymap:
                mymap.add(n)
            else:
                return True
        
        return False
        

