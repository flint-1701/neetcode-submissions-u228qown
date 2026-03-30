public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1;
        int r = piles.Max();
        int minHours = r;
        while(l<=r){
            int mid = (l+r)/2;
            int temp = 0;
            for(int i=0;i<piles.Length;i++){
                temp += (int)Math.Ceiling((double)piles[i] / mid);                
            }
            if(temp<=h){
                minHours = mid;
                r=mid-1;
            }
            else{
                l=mid+1;
            }
            
        }
        return minHours;
    }
}
