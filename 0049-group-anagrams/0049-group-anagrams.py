class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        ht = {}
        for word in strs:
            current_word = "".join(sorted(word))
            if  current_word not in ht:
                ht[current_word] = [word]
            else:
                ht[current_word].append(word)
        return ht.values()    