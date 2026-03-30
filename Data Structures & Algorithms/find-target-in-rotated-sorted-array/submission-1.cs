public class Solution {
    public int Search(int[] nums, int target) {
        int m = nums.Min();
        int mi = Array.IndexOf(nums,m);
        int left = Bins(0,mi,nums,target);
        int right = Bins(mi,nums.Length-1,nums,target);
        return Math.Max(left,right);    
    }

    public int Bins(int l,int r , int[] arr,int target){
        while(l<=r){
            int mid = l + (r-l)/2;
            if(arr[mid]==target) return mid;
            else if(arr[mid]>target){
                r = mid-1;
            }
            else{
                l=mid+1;
            }
        }
        return -1;
    }
}
