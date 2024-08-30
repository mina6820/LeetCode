class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        my_set = set()   # Set is Faster Than List
        cop = set(nums)
        for i in nums:
            if i in my_set:
                cop.remove(i)
            else:
                my_set.add(i)
        return cop.pop()