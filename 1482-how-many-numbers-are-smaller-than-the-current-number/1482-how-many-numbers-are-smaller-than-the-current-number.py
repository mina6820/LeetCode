class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        # create a frequency table of the numbers in nums
        freq = [0] * 101
        for num in nums:
            freq[num] += 1
        
        # calculate the number of smaller numbers for each number in nums
        smaller = [0] * len(nums)
        for i, num in enumerate(nums):
            smaller[i] = sum(freq[:num])
        
        return smaller