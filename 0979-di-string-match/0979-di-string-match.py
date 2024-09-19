class Solution:
    def diStringMatch(self, s: str) -> List[int]:
        lower = 0
        upper = len(s)
        perm =[]
        for char in s:
            if char == "I":
                perm.append(lower)
                lower +=1
            if char == "D":
                perm.append(upper)
                upper -=1
        if s[-1] == "I":
            perm.append(lower)   
        elif s[-1] == "D":
            perm.append(upper)         
        return perm