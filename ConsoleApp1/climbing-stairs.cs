using System;

// You are climbing a staircase. 
// It takes n steps to reach the top.
// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
// n = xa +b2a == (x+b)*4a

// n = 7
// 1. 7*1
// 2. 5*1 +1*2
// 3. 3*1 + 2*2
// 4. 1 + 3*2

// n = 5
// 1. 5*1
// 2. 3*1+2
// 3. 

// n =4
// 1. 1 +1 +1+1
// 2. 2+ 1+ 1
// 3. 1+2+1
// 4. 1+1+2
// 5. 2+2


// Example 1:
// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps

// Example 2:
// Input: n = 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step
// 
// for each 2 added, the size of the string of possibilty is reduced by 1
// the amount of possibility per case depends on the amount of 2s and the amount of 1s. The more options you have,
/// </summary>

public class ClimbingStairs
{

    public void Solve(int steps)
    {
        int[] m = new int[steps + 1];
        m[0] = 1;
        m[1] = 2;
        for (int i = 2; i < steps; i++)
        {
            m[i] = m[i - 1] + m[i - 2];
            if (i == steps-1)
            {
                Console.WriteLine(m[i]);
            }
        }
    }
}