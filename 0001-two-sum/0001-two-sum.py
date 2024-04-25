class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        # create an empty hash table
        ht = {}
        
        # loop through each element in the array
        for i in range(len(nums)):
            # calculate the complement of the current element
            complement = target - nums[i]
            
            # check if the complement exists in the hash table
            if complement in ht:
                # return the indices of the current element and its complement
                return [ht[complement], i]
            
            # otherwise, add the current element and its index to the hash table
            ht[nums[i]] = i
        
        # if no solution is found, return an empty array
        return []