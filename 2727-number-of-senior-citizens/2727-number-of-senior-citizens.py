class Solution:
    def countSeniors(self, details: List[str]) -> int:
        count = 0
        for paasenger in details:
            if int(paasenger[11:13]) > 60:
                count +=1
        return count