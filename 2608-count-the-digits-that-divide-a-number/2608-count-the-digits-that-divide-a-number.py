class Solution:
    def countDigits(self, n: int) -> int:
        count = 0
        for i in str(n):
            if int(n) % int(i) == 0:
                count += 1
        return count