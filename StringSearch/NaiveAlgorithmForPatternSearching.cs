using System;

namespace SharpAlgorithms.StringSearch
{
    /*
     * Naive Pattern Searching Algorithm Explanation:
     * 
     * The Naive Pattern Searching algorithm is a simple and straightforward method for finding
     * occurrences of a "pattern" string within a "text" string.
     * It checks for the pattern at every possible position in the text.
     * 
     * Time Complexity:
     * - Best Case: O(n) (when the first character of the pattern does not match any character in the text).
     * - Worst Case: O(n*m), where n is the length of the text and m is the length of the pattern.
     * 
     * This algorithm is not efficient for large texts or patterns but is easy to implement and understand.
     */

    public class NaivePatternSearchingAlgorithm
    {
        // Method to perform Naive Pattern Searching
        public static void PatternSearching(string txt, string pat)
        {
            int M = pat.Length;
            int N = txt.Length;

            // A loop to slide the pattern one by one
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                // For current index i, check for pattern match
                for (j = 0; j < M; j++)
                    if (txt[i + j] != pat[j])
                        break;

                // If pat[0...M-1] = txt[i, i+1, ...i+M-1]
                if (j == M)
                    Console.WriteLine("Pattern found at index " + i);
            }
        }
    }
}

/*
 * Visualization of Naive Pattern Search:
 * 
 * Text: "abcxabcdabcdabcy"
 * Pattern: "abcd"
 * 
 * Steps:
 * 1. Start at index 0:
 *    Compare the pattern with the substring starting at index 0: "abcx". No match.
 * 
 * 2. Move to index 1:
 *    Compare the pattern with the substring starting at index 1: "bcxa". No match.
 * 
 * 3. Continue until index 4:
 *    Compare the pattern with the substring starting at index 4: "abcd". Match found at index 4.
 * 
 * 4. Move to index 8:
 *    Compare the pattern with the substring starting at index 8: "abcd". Match found at index 8.
 * 
 * Result:
 * Pattern "abcd" is found at indices 4 and 8 in the text.
 */
