class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        l,r = 0, 0
        count, val = 0, 0

        while r < len(arr):
            val += arr[r]

            if r-l+1<k:
                r += 1

            else:
                if val // k >= threshold:
                    count += 1
                val -= arr[l]
                l += 1
                r += 1

        return count
