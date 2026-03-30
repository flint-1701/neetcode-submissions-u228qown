public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        for(int i=0;i<prices.Length-1;i++){
            for(int j=i+1;j<prices.Length;j++){
                if(result<(prices[j]-prices[i])){
                    result = prices[j]-prices[i];
                }
            }
        }
        return result;
    }
}
