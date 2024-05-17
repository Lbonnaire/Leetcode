// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

// Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

// You may assume that you have an infinite number of each kind of coin.

 

// Example 1:

// Input: coins = [1,2,5], amount = 11
// Output: 3
// Explanation: 11 = 5 + 5 + 1
// Example 2:

// Input: coins = [2], amount = 3
// Output: -1
// Example 3:

// Input: coins = [1], amount = 0
// Output: 0
 
// amount = x
// coins = [1,2,5]
// x = a*1 + b*2 + c*5
// create all possible of values that can be made with the coins array up until the value of the amount. Choose the one with the least options. 
// find the shortest way to create all possible values before the amount value.
// store a value in an array for each index, and then increment it.



// Constraints:

// 1 <= coins.length <= 12
// 1 <= coins[i] <= 231 - 1
// 0 <= amount <= 104

public void CoinChange(){
    public int Solve(int[] coinsArr, int value){
        int[]  sp = new int[value];
        Array.sort(coinsArr);
        List<int> possibleArr= new List<int>();
        for (int i=0; i< value,i++){
            for (int j=0 ; j<coinsArr.Length;i++){
                currValue=coinsArr[j];
                while (i-currValue<=value){
                    possibleArr.push(i-currValue);
                    currValue+=coinsArr[j];
                }
            }
        }
        
    }
}