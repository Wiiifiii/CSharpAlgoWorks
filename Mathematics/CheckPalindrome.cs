using System;

namespace SharpAlgorithms.Mathematics
{
    /*
     * Palindrome String Explanation:
     * 
     * A palindrome string is a sequence of characters that reads the same backward as forward. For example:
     * - "radar" is a palindrome.
     * - "hello" is not a palindrome.
     * 
     * Algorithm:
     * - Compare characters from the start and end of the string.
     * - If all characters match in reverse order, the string is a palindrome.
     * 
     * Example:
     * - Input: "radar"
     * - Result: Palindrome
     * 
     * Time Complexity: O(n), where n is the length of the string.
     * Space Complexity: O(1)
     */

    public class StringPalindromeChecker
    {
        // Method to check if a string is a palindrome
        public static bool CheckPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false; // Empty or null strings are not palindromes

            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                if (str[start] != str[end])
                    return false; // Mismatch found

                start++;
                end--;
            }

            return true; // All characters matched
        }
    }
}

/*
 * Visualization of Palindrome Check:
 * 
 * Input: "radar"
 * 
 * Steps:
 * 1. Compare first and last characters: 'r' == 'r' -> Match
 * 2. Move inward and compare: 'a' == 'a' -> Match
 * 3. Center character reached: 'd' -> No need to compare further
 * 
 * Result:
 * - All characters matched in reverse order.
 * - Output: Palindrome
 */
