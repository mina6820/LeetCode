class Solution:
    def isAnagram(self, original: str, new: str) -> bool:
        n = set(new)
        if len(original) != len(new):
            return False
        for char in n:
            if new.count(char) != original.count(char):
                return False
        return True
            