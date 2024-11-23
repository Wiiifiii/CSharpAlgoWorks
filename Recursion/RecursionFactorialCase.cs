using System;

namespace SharpAlgorithms.Recursion
{
    /*
     * Recursion: Factorial Calculation Explanation:
     * 
     * Factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
     * It is denoted as n! and is defined as:
     * 
     * n! = n * (n-1) * (n-2) * ... * 1
     * 
     * Recursive Approach:
     * - Base Case: 0! = 1 or 1! = 1
     * - Recursive Case: n! = n * (n-1)!
     * 
     * Example:
     * - 5! = 5 * 4!
     * - 4! = 4 * 3!
     * - 3! = 3 * 2!
     * - 2! = 2 * 1!
     * - 1! = 1
     * 
     * Time Complexity: O(n)
     * Space Complexity: O(n) (due to recursive function call stack)
     */

    public class RecursionFactorialExample
    {
        // Method to calculate factorial recursively
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            // Base Case: Factorial of 0 or 1 is 1
            if (n == 0 || n == 1)
                return 1;

            // Recursive Case: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }
    }
}

/*
 * Visualization of Recursion for Factorial:
 * 
 * Input: n = 5
 * 
 * Stack Trace:
 * - Factorial(5) -> 5 * Factorial(4)
 * - Factorial(4) -> 4 * Factorial(3)
 * - Factorial(3) -> 3 * Factorial(2)
 * - Factorial(2) -> 2 * Factorial(1)
 * - Factorial(1) -> 1
 * 
 * Result:
 * - 5! = 5 * 4 * 3 * 2 * 1 = 120
 * 
 * Output: 120
 */
