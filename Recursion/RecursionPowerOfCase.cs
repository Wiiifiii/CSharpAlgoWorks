using System;

namespace SharpAlgorithms.Recursion
{
    /*
     * Recursion: Power Calculation Explanation:
     * 
     * This algorithm calculates the result of raising a base number to an exponent using recursion.
     * 
     * Formula:
     * - Power(base, exponent) = base^exponent
     * - Base Case: Power(base, 0) = 1
     * - Recursive Case: Power(base, exponent) = base * Power(base, exponent - 1)
     * 
     * Example:
     * - Power(2, 3) = 2 * Power(2, 2)
     * - Power(2, 2) = 2 * Power(2, 1)
     * - Power(2, 1) = 2 * Power(2, 0)
     * - Power(2, 0) = 1
     * 
     * Result: 2^3 = 2 * 2 * 2 = 8
     * 
     * Time Complexity: O(exponent)
     * Space Complexity: O(exponent) (due to recursive function call stack)
     */

    public class RecursionPowerExample
    {
        // Method to calculate power recursively
        public static int PowerOf(int baseNumber, int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentException("This implementation does not handle negative exponents.");
            }

            // Base Case: Any number raised to the power of 0 is 1
            if (exponent == 0)
                return 1;

            // Recursive Case: base^exponent = base * base^(exponent-1)
            return baseNumber * PowerOf(baseNumber, exponent - 1);
        }
    }
}

/*
 * Visualization of Recursion for Power Calculation:
 * 
 * Input: baseNumber = 2, exponent = 3
 * 
 * Stack Trace:
 * - PowerOf(2, 3) -> 2 * PowerOf(2, 2)
 * - PowerOf(2, 2) -> 2 * PowerOf(2, 1)
 * - PowerOf(2, 1) -> 2 * PowerOf(2, 0)
 * - PowerOf(2, 0) -> 1
 * 
 * Result:
 * - 2^3 = 2 * 2 * 2 = 8
 * 
 * Output: 8
 */
