using System;

namespace SharpAlgorithms.StringSearch
{
    /*
     * Knuth-Morris-Pratt (KMP) Algorithm Explanation:
     * 
     * The Knuth-Morris-Pratt (KMP) algorithm searches for occurrences of a "pattern" string within a "text" string.
     * It employs the observation that when a mismatch occurs, the pattern itself contains sufficient information
     * to determine where the next match could begin, thus bypassing re-examination of previously matched characters.
     * 
     * Time Complexity:
     * - Preprocessing (LPS array): O(m), where m is the length of the pattern.
     * - Searching: O(n), where n is the length of the text.
     * 
     * This makes KMP an efficient algorithm for string matching.
     */

    public class KnuthMorrisPrattAlgorithm
    {
        // Method to perform KMP search
        public static void KMPSearching(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            // Create lps[] that will hold the longest prefix suffix values for the pattern
            int[] lps = new int[M];
            int j = 0; // Index for pat[]

            // Preprocess the pattern (calculate lps[] array)
            ComputeLPSArray(pat, M, lps);

            int i = 0; // Index for txt[]
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    Console.WriteLine("Found pattern at index " + (i - j));
                    j = lps[j - 1];
                }
                // Mismatch after j matches
                else if (i < N && pat[j] != txt[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, they will match anyway
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
        }

        // Method to compute the longest prefix suffix (LPS) array
        public static void ComputeLPSArray(string pat, int M, int[] lps)
        {
            // Length of the previous longest prefix suffix
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0

            // The loop calculates lps[i] for i = 1 to M-1
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}

/*
 * Visualization of KMP:
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
