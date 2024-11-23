using System;

namespace SharpAlgorithms.Trees
{
    /*
     * Binary Search Tree Explanation:
     * 
     * A Binary Search Tree (BST) is a hierarchical data structure in which:
     * - The left subtree of a node contains only nodes with keys less than the node’s key.
     * - The right subtree of a node contains only nodes with keys greater than the node’s key.
     * - The left and right subtree each must also be a binary search tree.
     */

    public class TreeNode
    {
        public int Value; // Value of the node
        public TreeNode Left; // Left child
        public TreeNode Right; // Right child

        public TreeNode(int value)
        {
            Value = value;
        }
    }

    public class BST
    {
        // Insert a value into the BST
        public static TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
                return new TreeNode(value);

            if (value < root.Value)
                root.Left = Insert(root.Left, value);
            else if (value > root.Value)
                root.Right = Insert(root.Right, value);

            return root;
        }

        // Search for a value in the BST
        public static TreeNode Search(TreeNode root, int value)
        {
            if (root == null || root.Value == value)
                return root;

            if (value < root.Value)
                return Search(root.Left, value);

            return Search(root.Right, value);
        }

        // In-order traversal
        public static void InOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InOrderTraversal(root.Right);
            }
        }
    }
}

/*
 * Visualization of BST Operations:
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
 */
