public class Solution {
    public int MaxArea(int[] heights) {
        int l=0,r=heights.Length-1;
        int maxArea = 0;
        while(l<r){
            int temp = (r-l) * Math.Min(heights[l],heights[r]);
                maxArea = Math.Max(maxArea,temp);
            if(heights[l]>=heights[r]){
                r--;
            }
            else{
                l++;
            }
        }
        return maxArea;
    }
}
