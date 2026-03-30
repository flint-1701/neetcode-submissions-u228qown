public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row=0;
        int n = matrix[row].Length-1;
        while(row<=matrix.Length-1){
            if(target>matrix[row][n]) {
                row++;
                continue;
            }
            else if(target<matrix[row][n]){
                int l=0;
                int r = matrix[row].Length-1;
                while(l<=r){
                    int mid = l+(r-l)/2;
                    if(matrix[row][mid]==target) return true;
                    else if(target < matrix[row][mid]){
                        r = mid-1;
                    }
                    else{
                        l= mid+1;
                    }
                }
                break;
            }
            else return true;
        }
        return false;
    }
}
