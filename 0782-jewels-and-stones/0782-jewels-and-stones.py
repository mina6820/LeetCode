class Solution:
    def numJewelsInStones(self, jewels: str, stones: str) -> int:
        count = 0
        new = list(jewels)
        for i in range(len(stones)):
            if stones[i] in new:
                count += 1
        return count        