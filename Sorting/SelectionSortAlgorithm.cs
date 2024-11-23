using System;

namespace SharpAlgorithms.Sorting
{
    /*
     * Selection Sort Explanation:
     * 
     * Selection Sort is a simple comparison-based sorting algorithm.
     * It divides the input list into two parts: 
     * - The sublist of items already sorted, which is built up from left to right at the front (low end) of the list.
     * - The sublist of items remaining to be sorted that occupy the rest of the list.
     * 
     * The algorithm repeatedly selects the smallest (or largest) element from the unsorted sublist, swapping it with the leftmost unsorted element.
     * 
     * Time Complexity:
     * - Best Case: O(n^2)
     * - Worst Case: O(n^2)
     * - Average Case: O(n^2)
     * 
     * Selection Sort is not efficient on large lists but can be useful when memory writes are costly.
     */

    public class SelectionSortExample
    {
        // Method to perform selection sort on an array
        public static void SelectionSort(int[] unsortedList)
        {
            for (int i = 0; i < unsortedList.Length - 1; i++) // n - 2 passes
            {
                int iMin = i; // i position elements from i till i - 1 are candidates
                for (int j = i + 1; j < unsortedList.Length; j++)
                {
                    if (unsortedList[j] < unsortedList[iMin])
                    {
                        iMin = j; // update the index of minimum element
                    }
                }
                // Swap the found minimum element with the first element
                int temp = unsortedList[i];
                unsortedList[i] = unsortedList[iMin];
                unsortedList[iMin] = temp;
            }
        }
    }
}

/*
 * Visualization of Selection Sort:
 * 
 * Initial Array: [2, 7, 4, 1, 5, 3]
 * 
 * Pass 1:
 * - Find the minimum element in the unsorted array [2, 7, 4, 1, 5, 3]
 * - Swap it with the first element
 * - Array after pass 1: [1, 7, 4, 2, 5, 3]
 * 
 * Pass 2:
 * - Find the minimum element in the unsorted array [7, 4, 2, 5, 3]
 * - Swap it with the second element
 * - Array after pass 2: [1, 2, 4, 7, 5, 3]
 * 
 * Pass 3:
 * - Find the minimum element in the unsorted array [4, 7, 5, 3]
 * - Swap it with the third element
 * - Array after pass 3: [1, 2, 3, 7, 5, 4]
 * 
 * Pass 4:
 * - Find the minimum element in the unsorted array [7, 5, 4]
 * - Swap it with the fourth element
 * - Array after pass 4: [1, 2, 3, 4, 5, 7]
 * 
 * Pass 5:
 * - Find the minimum element in the unsorted array [7]
 * - Swap it with the fifth element
 * - Array after pass 5: [1, 2, 3, 4, 5, 7]
 * 
 * Final Sorted Array: [1, 2, 3, 4, 5, 7]
 */
