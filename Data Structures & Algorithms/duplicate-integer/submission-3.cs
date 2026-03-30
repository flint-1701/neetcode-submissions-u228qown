public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> stored = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(stored.ContainsKey(nums[i])) return true;
            else stored[nums[i]] = 1;
        }
        return false;
    }
}