class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        new_lis = []
        for i in range(n):
            new_lis.append(nums[i])
            new_lis.append(nums[n+i])

        return new_lis