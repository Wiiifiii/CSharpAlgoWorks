using System;

namespace SharpAlgorithms.LinkedLists
{
    /*
     * Singly Linked List Explanation:
     * 
     * A Singly Linked List is a linear data structure where each element (node) points to the next node in the sequence.
     * Each node contains two fields:
     * - Data: The value stored in the node.
     * - Next: A reference to the next node in the list.
     * 
     * Operations:
     * - Add: Insert a node at the end or in sorted order.
     * - Print: Display the values in the list.
     * 
     * Example:
     * - Adding values: 1 -> 8 -> 15 -> 50
     * - Sorted insert of 9: 1 -> 8 -> 9 -> 15 -> 50
     */

    public class SinglyLinkedList
    {
        // Node class representing each element in the linked list
        private class Node
        {
            public int Data { get; set; } // Value of the node
            public Node Next { get; set; } // Reference to the next node

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head; // Head (start) of the linked list

        // Method to add a node in sorted order
        public void AddSorted(int data)
        {
            Node newNode = new Node(data);

            // If the list is empty or the new node should be the new head
            if (head == null || head.Data >= newNode.Data)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            // Traverse the list to find the correct insertion point
            Node current = head;
            while (current.Next != null && current.Next.Data < newNode.Data)
            {
                current = current.Next;
            }

            // Insert the new node
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // Method to print the linked list
        public void PrintList()
        {
            Node current = head;

            // Traverse and print all nodes
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    }
}

/*
 * Visualization of Singly Linked List:
 * 
 * Operations:
 * 1. AddSorted(15)
 *    List: 15 -> null
 * 
 * 2. AddSorted(8)
 *    List: 8 -> 15 -> null
 * 
 * 3. AddSorted(50)
 *    List: 8 -> 15 -> 50 -> null
 * 
 * 4. AddSorted(9)
 *    List: 8 -> 9 -> 15 -> 50 -> null
 * 
 * Output:
 * The sorted linked list is: 8 -> 9 -> 15 -> 50 -> null
 */
