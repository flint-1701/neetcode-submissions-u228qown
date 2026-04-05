public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> temp = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            temp[nums[i]] = i;
        }
        for(int i=0;i<nums.Length;i++){
            int comp = target - nums[i];
            if(temp.ContainsKey(comp) && temp[comp]!=i) return new int[]{i,temp[comp]};
        }
        return new int[]{0,0};
    }
}
