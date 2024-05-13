using System;
using System.Collections.Generic;
// ou are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

// You can either start from the step with index 0, or the step with index 1.

// Return the minimum cost to reach the top of the floor.

// Example 1:

// Input: cost = [10,15,20]
// Output: 15
// Explanation: You will start at index 1.
// - Pay 15 and climb two steps to reach the top.
// The total cost is 15.
// Example 2:

// Input: cost = [1,100,1,1,1,100,1,1,100,1]
// Output: 6
// Explanation: You will start at index 0.
// - Pay 1 and climb two steps to reach index 2.
// - Pay 1 and climb two steps to reach index 4.
// - Pay 1 and climb two steps to reach index 6.
// - Pay 1 and climb one step to reach index 7.
// - Pay 1 and climb two steps to reach index 9.
// - Pay 1 and climb one step to reach the top.
// The total cost is 6.
 

// Constraints:

// 2 <= cost.length <= 1000
// 0 <= cost[i] <= 999

public class Solution {
    int[] cost1 = new int[]{10, 15, 20};
    int[] cost2 = new int[]{1, 100, 1, 1, 1, 100, 1, 1, 100, 1};

    public static void Main(){
        Solution sol = new Solution();
        sol.Start();
    }
    private void Start(){
        Console.WriteLine(MinCostClimbingStairs(cost1));
        Console.WriteLine(MinCostClimbingStairs(cost2));
        
    }


    public int MinCostClimbingStairs(int[] cost) {
        // start 1 or 0
        int[] dp = new int[cost.Length]; // min cost from i to top of staircase  
        // assuming n length staircase from 0 to n-1, dp[n]=0
        for (int i = cost.Length-1; i>=0;i--){
            if (i >= cost.Length-2){
                dp[i] = cost[i];
            }else{
                dp[i] = min(cost[i]+dp[i+1],cost[i]+dp[i+2]);
            }
        }
        return min(dp[0], dp[1]);
    }

    private int min(int val1,int val2){
        if (val1< val2){
            return val1;
        }else{
            return val2;
        }
    }

}