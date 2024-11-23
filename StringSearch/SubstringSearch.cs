using System;

namespace SharpAlgorithms.StringSearch
{
    /*
     * Substring Search using KMP Explanation:
     * 
     * This implementation uses the Knuth-Morris-Pratt (KMP) algorithm to efficiently search
     * for a substring (pattern) within a larger string (text).
     * 
     * Time Complexity:
     * - Preprocessing (LPS array): O(m), where m is the length of the pattern.
     * - Searching: O(n), where n is the length of the text.
     * 
     * The KMP algorithm ensures that when a mismatch occurs, unnecessary re-checking of characters is avoided
     * by using the LPS (Longest Prefix Suffix) array.
     */

    public class KMPSubstringSearch
    {
        // Method to perform KMP substring search
        public bool KMP(char[] text, char[] pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            // Preprocess the pattern to create the LPS array
            int[] lps = new int[m];
            ComputeLPSArray(pattern, m, lps);

            int i = 0; // Index for text[]
            int j = 0; // Index for pattern[]

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == m)
                {
                    Console.WriteLine("Pattern found at index " + (i - j));
                    j = lps[j - 1];
                }
                else if (i < n && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }

            return false;
        }

        // Method to compute the LPS array
        private void ComputeLPSArray(char[] pattern, int m, int[] lps)
        {
            int length = 0; // Length of the previous longest prefix suffix
            int i = 1;
            lps[0] = 0; // LPS[0] is always 0

            while (i < m)
            {
                if (pattern[i] == pattern[length])
                {
                    length++;
                    lps[i] = length;
                    i++;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
        }
    }
}

/*
 * Visualization of Substring Search using KMP:
 * 
 * Text: "abcxabcdabcdabcy"
 * Pattern: "abcdabcy"
 * 
 * Steps:
 * 1. Preprocess the pattern to create the LPS array:
 *    Pattern:  a b c d a b c y
 *    LPS:      0 0 0 0 1 2 3 0
 * 
 * 2. Use the LPS array to search the pattern in the text:
 *    - Compare the pattern with substrings of the text and skip unnecessary comparisons.
 * 
 * Result:
 * The pattern "abcdabcy" is found at index 8 in the text.
 */
