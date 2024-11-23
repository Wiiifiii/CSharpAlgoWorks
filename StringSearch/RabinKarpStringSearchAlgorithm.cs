using System;

namespace SharpAlgorithms.StringSearch
{
    /*
     * Rabin-Karp Algorithm Explanation:
     * 
     * The Rabin-Karp algorithm is a string-searching algorithm that uses hashing to find any one of a set
     * of pattern strings in a text. The algorithm calculates a hash value for the pattern and for each substring
     * of the text of the same length as the pattern. It then compares the hash values.
     * 
     * If the hash values match, the algorithm checks the actual characters of the substring and the pattern
     * to confirm a match (to handle hash collisions).
     * 
     * Time Complexity:
     * - Best Case: O(n + m), where n is the length of the text and m is the length of the pattern.
     * - Worst Case: O(n*m) (due to hash collisions).
     */

    public class RabinKarpStringSearchAlgorithm
    {
        // d is the number of characters in the input alphabet
        public readonly static int d = 256;

        // Method to perform Rabin-Karp search
        public static void RabinKarpSearch(string pat, string txt, int q)
        {
            int M = pat.Length;
            int N = txt.Length;
            int i, j;
            int p = 0; // hash value for pattern
            int t = 0; // hash value for text
            int h = 1;

            // The value of h would be "pow(d, M-1)%q"
            for (i = 0; i < M - 1; i++)
                h = (h * d) % q;

            // Calculate the hash value of the pattern and the first window of the text
            for (i = 0; i < M; i++)
            {
                p = (d * p + pat[i]) % q;
                t = (d * t + txt[i]) % q;
            }

            // Slide the pattern over the text one by one
            for (i = 0; i <= N - M; i++)
            {
                // Check the hash values of the current window of text and the pattern
                if (p == t)
                {
                    // Check characters one by one in case of a hash match
                    for (j = 0; j < M; j++)
                    {
                        if (txt[i + j] != pat[j])
                            break;
                    }

                    if (j == M)
                        Console.WriteLine("Pattern found at index " + i);
                }

                // Calculate hash value for the next window of text
                if (i < N - M)
                {
                    t = (d * (t - txt[i] * h) + txt[i + M]) % q;

                    // We might get a negative value of t, convert it to positive
                    if (t < 0)
                        t = (t + q);
                }
            }
        }
    }
}

/*
 * Visualization of Rabin-Karp:
 * 
 * Text: "abcxabcdabcdabcy"
 * Pattern: "abcd"
 * 
 * Steps:
 * 1. Compute the hash value of the pattern "abcd".
 *    Pattern hash = 97*256^3 + 98*256^2 + 99*256^1 + 100*256^0 (mod q)
 * 
 * 2. Compute the hash value of each substring in the text of length 4 and compare:
 *    - Substring "abcx" hash does not match.
 *    - Substring "abcd" hash matches. Check actual characters.
 * 
 * 3. Slide the window and repeat.
 * 
 * Result:
 * Pattern "abcd" is found at indices 4 and 8 in the text.
 */
