public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> result = new Dictionary<int,int>();
        int max = 0;
        int len = 1;
        Array.Sort(nums);
        if(nums.Length < 3) return new HashSet<int>(nums).Count;;
        for(int i=0;i<nums.Length;i++){
            if(result.ContainsKey(nums[i])){
                result[nums[i]]++;
            }
            else{
                result[nums[i]] = 1;
            }
        }
        foreach(int j in result.Keys){
            if(result.ContainsKey(j+1)){
                len++;
                continue;
            }
            else{
                if(len>max) max = len;
                len = 1;
            }
            
        }
        return max;
    }
}
