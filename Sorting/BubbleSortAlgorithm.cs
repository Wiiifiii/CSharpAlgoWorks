using System;

namespace SharpAlgorithms.Sorting
{
    /*
     * Bubble Sort Explanation:
     * 
     * Bubble Sort is a simple sorting algorithm that repeatedly steps through the list,
     * compares adjacent elements, and swaps them if they are in the wrong order.
     * The pass through the list is repeated until the list is sorted.
     * 
     * Time Complexity:
     * - Best Case: O(n) (when the array is already sorted)
     * - Worst Case: O(n^2) (when the array is sorted in reverse order)
     * 
     * Bubble Sort gets its name because smaller elements "bubble" to the top of the list.
     */

    public class BubbleSortDemo
    {
        // Method to perform Bubble Sort on an array
        public static void BubbleSort(double[] unsortedList)
        {
            double temp;
            // Outer loop to iterate over the entire array
            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                // Inner loop to compare adjacent elements
                for (int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    // If the current element is less than the next element, swap them
                    // Change '<' to '>' for ascending order
                    if (unsortedList[j] < unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }
        }
    }
}

/*
 * Visualization of Bubble Sort:
 * 
 * Initial Array: [35, 1, 28, 11, 8, 14]
 * 
 * Pass 1:
 * [35, 28, 1, 11, 14, 8]
 * 
 * Pass 2:
 * [35, 28, 11, 14, 8, 1]
 * 
 * Pass 3:
 * [35, 28, 14, 11, 8, 1]
 * 
 * Pass 4:
 * [35, 28, 14, 11, 8, 1]
 * 
 * Pass 5:
 * [35, 28, 14, 11, 8, 1]
 * 
 * Sorted Array: [35, 28, 14, 11, 8, 1]
 */
