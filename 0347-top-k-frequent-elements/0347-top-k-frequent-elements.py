class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        output=[]
        
        for num in set(nums):
            count[num]=nums.count(num) 
            
        values = sorted(count.values())
        max=values[-k:]
        
        for key, value in count.items():
            if value in max:
                output.append(key)

        return output