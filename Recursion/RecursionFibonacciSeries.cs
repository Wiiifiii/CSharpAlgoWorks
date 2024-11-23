using System;

namespace SharpAlgorithms.Recursion
{
    /*
     * Recursion: Fibonacci Series Explanation:
     * 
     * The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones.
     * The sequence starts with 0 and 1:
     * 
     * F(0) = 0, F(1) = 1
     * F(n) = F(n-1) + F(n-2) for n > 1
     * 
     * Example:
     * - F(2) = F(1) + F(0) = 1 + 0 = 1
     * - F(3) = F(2) + F(1) = 1 + 1 = 2
     * - F(4) = F(3) + F(2) = 2 + 1 = 3
     * - F(5) = F(4) + F(3) = 3 + 2 = 5
     * 
     * Recursive Approach:
     * - Base Case: F(0) = 0, F(1) = 1
     * - Recursive Case: F(n) = F(n-1) + F(n-2)
     * 
     * Time Complexity: O(2^n)
     * Space Complexity: O(n) (due to recursive function call stack)
     */

    public class RecursionFibonacciExample
    {
        // Method to calculate Fibonacci number recursively
        public static int FibCalculator(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Fibonacci is not defined for negative numbers.");
            }

            // Base Case: F(0) = 0, F(1) = 1
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            // Recursive Case: F(n) = F(n-1) + F(n-2)
            return FibCalculator(n - 1) + FibCalculator(n - 2);
        }
    }
}

/*
 * Visualization of Recursion for Fibonacci Series:
 * 
 * Input: n = 5
 * 
 * Stack Trace:
 * - FibCalculator(5) -> FibCalculator(4) + FibCalculator(3)
 * - FibCalculator(4) -> FibCalculator(3) + FibCalculator(2)
 * - FibCalculator(3) -> FibCalculator(2) + FibCalculator(1)
 * - FibCalculator(2) -> FibCalculator(1) + FibCalculator(0)
 * 
 * Result:
 * - F(5) = F(4) + F(3) = (3 + 2) + (2 + 1) = 5
 * 
 * Output: 5
 */
