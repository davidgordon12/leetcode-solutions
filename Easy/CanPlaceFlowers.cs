public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0) return true;
        if(flowerbed.Length == 1 && flowerbed[0] == 1) return false;
        if(flowerbed.Length == 1 && flowerbed[0] == 0) return true;

        int spots = 0;

        for(int i = 0; i < flowerbed.Length; i++) {
            if(i > 0 && i < flowerbed.Length-1) {
                if(flowerbed[i-1] == 0 && flowerbed[i] == 0 && flowerbed[i+1] == 0) {
                    spots++;
                    i++;
                }
            }
            else if(i == 0) {
                if(flowerbed[i] == 0 && flowerbed[i+1] == 0) {
                    spots++;
                    i++;
                }
            }
            else if(i == flowerbed.Length-1) {
                if(flowerbed[i] == 0 && flowerbed[i-1] == 0) {
                    spots++;
                    i++;
                }
            }
        }

        if(spots >= n) {
            return true;
        }

        return false;
    }
}