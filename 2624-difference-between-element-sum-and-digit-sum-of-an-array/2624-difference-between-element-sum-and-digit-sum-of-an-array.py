class Solution:
    def differenceOfSum(self, nums: List[int]) -> int:
        return sum(map(lambda n: n - sum(map(int, str(n))), nums))