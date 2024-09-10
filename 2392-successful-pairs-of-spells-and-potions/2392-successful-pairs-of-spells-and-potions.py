class Solution:
    def successfulPairs(self, spells: List[int], potions: List[int], success: int) -> List[int]:
        n = len(spells)
        m = len(potions)
        result = [0] * n
        potions.sort()

        for i in range(n):
            index = bisect.bisect_left(potions, (success - 1) // spells[i] + 1)
            result[i] = m - index

        return result