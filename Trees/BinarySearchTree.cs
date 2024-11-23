using System;

namespace SharpAlgorithms.Trees
{
    /*
     * Binary Search Tree (BST) Explanation:
     * 
     * A Binary Search Tree is a data structure that maintains elements in a sorted order, allowing for efficient insertion, deletion, and lookup operations.
     * - Each node has at most two children: 
     *   - The left child is less than the parent node.
     *   - The right child is greater than the parent node.
     * 
     * Operations:
     * - Insert: O(log n) on average for balanced trees, O(n) in the worst case.
     * - Search: O(log n) on average for balanced trees, O(n) in the worst case.
     * - Delete: O(log n) on average for balanced trees, O(n) in the worst case.
     */

    // Class representing a binary search tree
    public class BinarySearchTree
    {
        // Represents a node in the binary search tree
        private class TreeNode
        {
            public int Data { get; set; } // Value of the node
            public TreeNode LeftNode { get; set; } // Left child
            public TreeNode RightNode { get; set; } // Right child

            public TreeNode(int data)
            {
                Data = data;
            }
        }

        private TreeNode Root { get; set; } // Root of the BST

        // Method to add a new node to the tree
        public void Add(int value)
        {
            Root = AddRecursive(Root, value);
        }

        private TreeNode AddRecursive(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.Data)
                node.LeftNode = AddRecursive(node.LeftNode, value);
            else if (value > node.Data)
                node.RightNode = AddRecursive(node.RightNode, value);

            return node;
        }

        // Method to search for a value in the tree
        public bool Search(int value)
        {
            return SearchRecursive(Root, value) != null;
        }

        private TreeNode SearchRecursive(TreeNode node, int value)
        {
            if (node == null || node.Data == value)
                return node;

            if (value < node.Data)
                return SearchRecursive(node.LeftNode, value);
            else
                return SearchRecursive(node.RightNode, value);
        }

        // In-order traversal (left, root, right)
        public void InOrderTraversal()
        {
            InOrderTraversalRecursive(Root);
        }

        private void InOrderTraversalRecursive(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.LeftNode);
                Console.Write(node.Data + " ");
                InOrderTraversalRecursive(node.RightNode);
            }
        }
    }
}

/*
 * Visualization of Binary Search Tree:
 * 
 * Initial Tree (Empty):
 * (empty)
 * 
 * Insert 30:
 *       30
 * 
 * Insert 15:
 *       30
 *      /
 *    15
 * 
 * Insert 45:
 *       30
 *      /  \
 *    15   45
 * 
 * Insert 6:
 *       30
 *      /  \
 *    15   45
 *   /
 *  6
 * 
 * Insert 41:
 *       30
 *      /  \
 *    15   45
 *   /     /
 *  6    41
 * 
 * Insert 54:
 *       30
 *      /  \
 *    15   45
 *   /     / \
 *  6    41 54
 * 
 * Insert 85:
 *       30
 *      /  \
 *    15   45
 *   /     / \
 *  6    41 54
 *             \
 *             85
 */
