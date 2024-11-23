using System;

namespace SharpAlgorithms.Sorting
{
    /*
     * Insertion Sort Explanation:
     * 
     * Insertion Sort is a simple sorting algorithm that builds the final sorted array one item at a time.
     * It is much less efficient on large lists than more advanced algorithms such as quicksort, heapsort, or merge sort.
     * 
     * Time Complexity:
     * - Best Case: O(n) (when the array is already sorted)
     * - Worst Case: O(n^2) (when the array is sorted in reverse order)
     * - Average Case: O(n^2)
     * 
     * This algorithm is more efficient for small datasets or nearly sorted data.
     */

    public class InsertionSortAlgorithm
    {
        // Method to perform Insertion Sort on an array
        public static void InsertionSort(double[] unsortedList)
        {
            for (int i = 1; i < unsortedList.Length; i++)
            {
                double key = unsortedList[i];
                int j = i - 1;

                // Move elements of unsortedList[0..i-1], that are greater than the key, to one position ahead of their current position
                while (j >= 0 && unsortedList[j] > key)
                {
                    unsortedList[j + 1] = unsortedList[j];
                    j--;
                }
                unsortedList[j + 1] = key;
            }
        }
    }
}

/*
 * Visualization of Insertion Sort:
 * 
 * Initial Array: [10, 4, 8, 6, 7]
 * 
 * Pass 1:
 * [4, 10, 8, 6, 7]
 * 
 * Pass 2:
 * [4, 8, 10, 6, 7]
 * 
 * Pass 3:
 * [4, 6, 8, 10, 7]
 * 
 * Pass 4:
 * [4, 6, 7, 8, 10]
 * 
 * Sorted Array: [4, 6, 7, 8, 10]
 */
