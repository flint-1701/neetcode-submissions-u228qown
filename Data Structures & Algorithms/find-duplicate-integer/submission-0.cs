public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int,int> result = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(result.ContainsKey(nums[i])){
                return nums[i];
            }
            else{
                result[nums[i]] = 1;
            }
        }
        return 0;
    }
}
