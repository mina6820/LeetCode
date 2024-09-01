class Solution:
    def mostWordsFound(self, sentences: List[str]) -> int:
        count = []
        for i in sentences:
            count.append(i.count(" "))      
        return max(count)+1
