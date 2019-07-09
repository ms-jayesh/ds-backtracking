/* you are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Note: Given n will be a positive integer.*/

public class Solution {
    public int ClimbingStairsRecursive(int K) {
       if(k<0)
            return 0;
       if(k==0)
            return 1;
        else
        {
            ClimbingStairsRecursive(k-1)+
            ClimbingStairsRecursive(k-2);
        }

    }
     public int climbingStairsDP(int K)
     {
         int dp1 = 1;
         int dp2 = 2;
         
         for(int i = 3;i<=K;i++)
         {
             var t = dp2;
             dp2 = dp1+dp2;
             dp1 = t;
         }
         return dp2;
     }
}
