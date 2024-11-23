using System;

namespace SharpAlgorithms.Mathematics
{
    /*
     * Palindrome Number Explanation:
     * 
     * A palindrome number is a number that reads the same backward as forward. For example:
     * - 121 is a palindrome (reads the same forward and backward).
     * - 123 is not a palindrome (reads as 321 backward).
     * 
     * Algorithm:
     * - Reverse the number and compare it with the original number.
     * - If they are the same, the number is a palindrome.
     * 
     * Example:
     * - Input: 121
     * - Reverse: 121
     * - Result: Palindrome
     * 
     * Time Complexity: O(d), where d is the number of digits in the input.
     * Space Complexity: O(1)
     */

    public class PalindromeChecker
    {
        // Method to check if a number is a palindrome
        public static bool IsPalindrome(int number)
        {
            if (number < 0)
                return false; // Negative numbers are not palindromes

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10; // Get the last digit
                reversedNumber = reversedNumber * 10 + digit; // Build the reversed number
                number /= 10; // Remove the last digit
            }

            return originalNumber == reversedNumber;
        }
    }
}

/*
 * Visualization of Palindrome Check:
 * 
 * Input: 121
 * 
 * Steps:
 * 1. Extract the last digit: 121 % 10 = 1
 *    Reversed Number: 0 * 10 + 1 = 1
 *    Remaining Number: 121 / 10 = 12
 * 
 * 2. Extract the last digit: 12 % 10 = 2
 *    Reversed Number: 1 * 10 + 2 = 12
 *    Remaining Number: 12 / 10 = 1
 * 
 * 3. Extract the last digit: 1 % 10 = 1
 *    Reversed Number: 12 * 10 + 1 = 121
 *    Remaining Number: 1 / 10 = 0
 * 
 * Compare:
 * - Original Number: 121
 * - Reversed Number: 121
 * - Result: Palindrome
 */
