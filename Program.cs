using System;
using System.Linq;
using SharpAlgorithms.Trees;
using SharpAlgorithms.Sorting;
using SharpAlgorithms.LinkedLists;
using SharpAlgorithms.StringSearch;
using SharpAlgorithms.Recursion;
using SharpAlgorithms.Mathematics;

namespace SharpAlgorithms
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose an algorithm to test:");
                Console.WriteLine("1. AVL Tree");
                Console.WriteLine("2. Binary Search Tree");
                Console.WriteLine("3. Fibonacci Series");
                Console.WriteLine("4. Factorial (Recursion)");
                Console.WriteLine("5. Power Calculation (Recursion)");
                Console.WriteLine("6. Bubble Sort");
                Console.WriteLine("7. Selection Sort");
                Console.WriteLine("8. Insertion Sort");
                Console.WriteLine("9. Naive String Search");
                Console.WriteLine("10. Rabin-Karp String Search");
                Console.WriteLine("11. Knuth-Morris-Pratt (KMP) String Search");
                Console.WriteLine("12. Check Palindrome (String)");
                Console.WriteLine("13. Check Palindrome (Number)");
                Console.WriteLine("14. Singly Linked List");
                Console.WriteLine("15. Exit");
                Console.Write("Enter your choice (1-15): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InteractiveAVLTree();
                        break;
                    case "2":
                        InteractiveBinarySearchTree();
                        break;
                    case "3":
                        InteractiveFibonacciSeries();
                        break;
                    case "4":
                        InteractiveFactorial();
                        break;
                    case "5":
                        InteractivePowerCalculation();
                        break;
                    case "6":
                        InteractiveBubbleSort();
                        break;
                    case "7":
                        InteractiveSelectionSort();
                        break;
                    case "8":
                        InteractiveInsertionSort();
                        break;
                    case "9":
                        InteractiveNaiveStringSearch();
                        break;
                    case "10":
                        InteractiveRabinKarpStringSearch();
                        break;
                    case "11":
                        InteractiveKMPSearch();
                        break;
                    case "12":
                        InteractivePalindromeString();
                        break;
                    case "13":
                        InteractivePalindromeNumber();
                        break;
                    case "14":
                        InteractiveSinglyLinkedList();
                        break;
                    case "15":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void InteractiveAVLTree()
        {
            Console.WriteLine("\nInteractive AVL Tree:");
            AVLTree tree = new AVLTree();
            Console.WriteLine("Enter numbers to insert into the AVL Tree, separated by spaces:");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var num in numbers)
            {
                tree.root = tree.Insert(tree.root, num);
            }

            Console.WriteLine("In-order Traversal of AVL Tree (sorted order):");
            tree.InOrder(tree.root);
            Console.WriteLine();
        }

        private static void InteractiveBinarySearchTree()
        {
            Console.WriteLine("\nInteractive Binary Search Tree:");
            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine("Enter numbers to insert into the Binary Search Tree, separated by spaces:");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var num in numbers)
            {
                bst.Add(num);
            }

            Console.WriteLine("In-order Traversal of Binary Search Tree (sorted order):");
            bst.InOrderTraversal();
            Console.WriteLine();
        }

        private static void InteractiveFibonacciSeries()
        {
            Console.WriteLine("\nInteractive Fibonacci Series:");
            Console.Write("Enter the number of terms to generate: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Generating the first {n} numbers in the Fibonacci sequence:");
            FibonacciSeriesGenerator.PrintFibonacciSeries(n);
            Console.WriteLine();
        }

        private static void InteractiveFactorial()
        {
            Console.WriteLine("\nInteractive Factorial (Recursion):");
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());
            int result = RecursionFactorialExample.Factorial(number);
            Console.WriteLine($"The factorial of {number} is: {result}\n");
        }

        private static void InteractivePowerCalculation()
        {
            Console.WriteLine("\nInteractive Power Calculation (Recursion):");
            Console.Write("Enter the base number: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());
            int result = RecursionPowerExample.PowerOf(baseNum, exponent);
            Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}\n");
        }

        private static void InteractiveBubbleSort()
        {
            Console.WriteLine("\nInteractive Bubble Sort:");
            Console.Write("Enter numbers to sort, separated by spaces: ");
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine("Sorting in descending order...");
            BubbleSortDemo.BubbleSort(array);
            Console.WriteLine("Sorted Array: " + string.Join(", ", array) + "\n");
        }

        private static void InteractiveSelectionSort()
        {
            Console.WriteLine("\nInteractive Selection Sort:");
            Console.Write("Enter numbers to sort, separated by spaces: ");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Sorting in ascending order...");
            SelectionSortExample.SelectionSort(array);
            Console.WriteLine("Sorted Array: " + string.Join(", ", array) + "\n");
        }

        private static void InteractiveInsertionSort()
        {
            Console.WriteLine("\nInteractive Insertion Sort:");
            Console.Write("Enter numbers to sort, separated by spaces: ");
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine("Sorting in ascending order...");
            InsertionSortAlgorithm.InsertionSort(array);
            Console.WriteLine("Sorted Array: " + string.Join(", ", array) + "\n");
        }

        private static void InteractiveNaiveStringSearch()
        {
            Console.WriteLine("\nInteractive Naive String Search:");
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the pattern to search: ");
            string pattern = Console.ReadLine();
            NaivePatternSearchingAlgorithm.PatternSearching(text, pattern);
            Console.WriteLine();
        }

        private static void InteractiveRabinKarpStringSearch()
        {
            Console.WriteLine("\nInteractive Rabin-Karp String Search:");
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the pattern to search: ");
            string pattern = Console.ReadLine();
            RabinKarpStringSearchAlgorithm.RabinKarpSearch(pattern, text, 101);
            Console.WriteLine();
        }

        private static void InteractiveKMPSearch()
        {
            Console.WriteLine("\nInteractive Knuth-Morris-Pratt (KMP) String Search:");
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the pattern to search: ");
            string pattern = Console.ReadLine();
            KMPSubstringSearch kmp = new KMPSubstringSearch();
            kmp.KMP(text.ToCharArray(), pattern.ToCharArray());
            Console.WriteLine();
        }

        private static void InteractivePalindromeString()
        {
            Console.WriteLine("\nInteractive Palindrome Check (String):");
            Console.Write("Enter a string to check: ");
            string input = Console.ReadLine();
            bool result = StringPalindromeChecker.CheckPalindrome(input);
            Console.WriteLine($"Is \"{input}\" a palindrome? {result}\n");
        }

        private static void InteractivePalindromeNumber()
        {
            Console.WriteLine("\nInteractive Palindrome Check (Number):");
            Console.Write("Enter a number to check: ");
            int input = int.Parse(Console.ReadLine());
            bool result = PalindromeChecker.IsPalindrome(input);
            Console.WriteLine($"Is {input} a palindrome? {result}\n");
        }

        private static void InteractiveSinglyLinkedList()
        {
            Console.WriteLine("\nInteractive Singly Linked List:");
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Enter numbers to add to the linked list (sorted), separated by spaces: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var num in numbers)
            {
                linkedList.AddSorted(num);
            }

            Console.WriteLine("Singly Linked List (sorted order):");
            linkedList.PrintList();
            Console.WriteLine();
        }
    }
}
