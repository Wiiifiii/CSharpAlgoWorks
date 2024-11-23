using System;

namespace SharpAlgorithms.Trees
{
    /*
     * AVL Tree Explanation:
     * 
     * An AVL tree is a self-balancing binary search tree where the difference between the heights
     * of the left and right subtrees cannot be more than one for all nodes.
     * 
     * AVL trees ensure that the tree remains balanced after every insertion and deletion operation.
     * This is achieved by performing rotations (left and right) to maintain the balance factor of each node.
     * 
     * The AVL tree provides efficient search, insertion, and deletion operations with a time complexity
     * of O(log n), making it suitable for applications where frequent insertions and deletions are required
     * while maintaining sorted order.
     */

    // Node class representing each node in the AVL tree
    public class AVLNode
    {
        public AVLNode LeftNode { get; set; } // Left child
        public AVLNode RightNode { get; set; } // Right child
        public int Data { get; set; } // Value of the node
        public int Height { get; set; } // Height of the node

        // Constructor to initialize a new node with a value
        public AVLNode(int value)
        {
            Data = value;
            Height = 1; // New node is initially added at leaf
        }
    }

    // AVL tree class
    public class AVLTree
    {
        public AVLNode root; // Root node of the AVL tree

        // Method to get the height of a node
        public int GetHeight(AVLNode node)
        {
            return node == null ? 0 : node.Height;
        }

        // Method to get the balance factor of a node
        public int GetBalanceFactor(AVLNode node)
        {
            return node == null ? 0 : GetHeight(node.LeftNode) - GetHeight(node.RightNode);
        }

        // Method to perform left rotation
        public AVLNode LeftRotate(AVLNode node)
        {
            AVLNode newRoot = node.RightNode;
            node.RightNode = newRoot.LeftNode;
            newRoot.LeftNode = node;

            node.Height = Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;
            newRoot.Height = Math.Max(GetHeight(newRoot.LeftNode), GetHeight(newRoot.RightNode)) + 1;

            return newRoot;
        }

        // Method to perform right rotation
        public AVLNode RightRotate(AVLNode node)
        {
            AVLNode newRoot = node.LeftNode;
            node.LeftNode = newRoot.RightNode;
            newRoot.RightNode = node;

            node.Height = Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;
            newRoot.Height = Math.Max(GetHeight(newRoot.LeftNode), GetHeight(newRoot.RightNode)) + 1;

            return newRoot;
        }

        // Method to insert a node in the AVL tree
        public AVLNode Insert(AVLNode node, int value)
        {
            if (node == null)
                return new AVLNode(value);

            if (value < node.Data)
                node.LeftNode = Insert(node.LeftNode, value);
            else if (value > node.Data)
                node.RightNode = Insert(node.RightNode, value);
            else
                return node; // Duplicate values are not allowed

            node.Height = Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;

            int balance = GetBalanceFactor(node);

            if (balance > 1 && value < node.LeftNode.Data)
                return RightRotate(node);

            if (balance > 1 && value > node.LeftNode.Data)
            {
                node.LeftNode = LeftRotate(node.LeftNode);
                return RightRotate(node);
            }

            if (balance < -1 && value > node.RightNode.Data)
                return LeftRotate(node);

            if (balance < -1 && value < node.RightNode.Data)
            {
                node.RightNode = RightRotate(node.RightNode);
                return LeftRotate(node);
            }

            return node;
        }

        // Method to perform in-order traversal of the AVL tree
        public void InOrder(AVLNode node)
        {
            if (node != null)
            {
                InOrder(node.LeftNode);
                Console.Write(node.Data + " ");
                InOrder(node.RightNode);
            }
        }
    }
}

/*
 * Visualization of AVL Tree Operations:
 * 
 * Insert 33:
 *       33
 * 
 * Insert 13:
 *       33
 *      /
 *    13
 * 
 * Insert 53:
 *       33
 *      /  \
 *    13   53
 * 
 * Insert 9:
 *       33
 *      /  \
 *    13   53
 *   /
 *  9
 * 
 * Insert 61:
 *       33
 *      /  \
 *    13   53
 *   /      \
 *  9       61
 * 
 * Final Structure:
 *       33
 *      /  \
 *    13   53
 *   /      \
 *  9       61
 */
