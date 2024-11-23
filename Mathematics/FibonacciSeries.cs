using System;

namespace SharpAlgorithms.Mathematics
{
    /*
     * Fibonacci Series Explanation:
     * 
     * The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones,
     * starting from 0 and 1. The sequence is defined as:
     * 
     * F(0) = 0, F(1) = 1
     * F(n) = F(n-1) + F(n-2) for n > 1
     * 
     * Example:
     * - F(0) = 0, F(1) = 1
     * - F(2) = 1 (0 + 1)
     * - F(3) = 2 (1 + 1)
     * - F(4) = 3 (2 + 1)
     * - F(5) = 5 (3 + 2)
     * 
     * Iterative Approach:
     * - This implementation calculates the Fibonacci sequence iteratively to improve efficiency.
     * 
     * Time Complexity: O(n)
     * Space Complexity: O(1)
     */

    public class FibonacciSeriesGenerator
    {
        // Method to generate Fibonacci series up to 'n' terms
        public static void PrintFibonacciSeries(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Please enter a positive number greater than 0.");
                return;
            }

            int first = 0, second = 1;

            Console.Write("Fibonacci Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}

/*
 * Visualization of Fibonacci Series:
 * 
 * Input: n = 6
 * 
 * Steps:
 * 1. Initialize: first = 0, second = 1
 * 2. Iteration 1: Print first (0), calculate next (0 + 1 = 1)
 * 3. Iteration 2: Print second (1), calculate next (1 + 1 = 2)
 * 4. Iteration 3: Print next (1), calculate next (1 + 2 = 3)
 * 5. Iteration 4: Print next (2), calculate next (2 + 3 = 5)
 * 6. Iteration 5: Print next (3), calculate next (3 + 5 = 8)
 * 7. Iteration 6: Print next (5)
 * 
 * Output:
 * Fibonacci Series: 0 1 1 2 3 5
 */
