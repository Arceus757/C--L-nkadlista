using System;
using System.Collections.Generic;

class SingleLinkedList<T>
{
    Node<T> head;

    public SingleLinkedList()
    {
        head = null;
    }

    // Add a node at the beginning
    public void addFirst(T data)
    {
        head = new Node<T>(data, head);
    }

    // Add a node at the end
    public void addNodeLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node<T> temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Remove a node at a specific position
    public void removeNode(int position)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (position < 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        // Remove first node
        if (position == 0)
        {
            head = head.Next;
            return;
        }

        Node<T> temp = head;
        int count = 0;

        // Traverse to the node before the target
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        // If position is out of bounds
        if (temp == null || temp.Next == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        // Remove the node by skipping it
        temp.Next = temp.Next.Next;
    }

    // Print the list
    public void printList()
    {
        Node<T> temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}
