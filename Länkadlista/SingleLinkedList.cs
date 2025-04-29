using System;
using System.Collections.Generic;

class SingleLinkedList<T>
{
    Node<T> head;

    public SingleLinkedList()
    {
        head = null;
    }

    // Lägger till en nod i början av listan
    public void addFirst(T data)
    {
        head = new Node<T>(data, head);
    }

    // Lägger till en nod i slutet av listan
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

    // Tar bort en nod på en specifik position
    public void removeNode(int position)
    {
        if (head == null)
        {
            Console.WriteLine("Listan är tom.");
            return;
        }

        if (position < 0)
        {
            Console.WriteLine("Ogiltig position.");
            return;
        }

        // Tar bort den första noden
        if (position == 0)
        {
            head = head.Next;
            return;
        }

        Node<T> temp = head;
        int count = 0;

        // Går till noden innan den som ska tas bort
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        // Om positionen är utanför listans gränser
        if (temp == null || temp.Next == null)
        {
            Console.WriteLine("Positionen är utanför listans gränser.");
            return;
        }

        // Hoppar över noden som ska tas bort
        temp.Next = temp.Next.Next;
    }

    // Sorterar listan med Bubble Sort genom att flytta pekarna
    public void bubbleSort(IComparer<T> comparer)
    {
        if (head == null || head.Next == null)
        {
            return; // Listan är tom eller har bara en nod
        }

        bool swapped;
        do
        {
            swapped = false;
            Node<T> current = head;
            Node<T> prev = null;

            while (current != null && current.Next != null)
            {
                Node<T> next = current.Next;

                // Jämför data i den aktuella noden och nästa nod
                if (comparer.Compare(current.Data, next.Data) > 0)
                {
                    // Byter plats på noderna genom att justera pekarna
                    if (prev == null)
                    {
                        // Byter plats på de två första noderna
                        head = next;
                    }
                    else
                    {
                        prev.Next = next;
                    }

                    current.Next = next.Next;
                    next.Next = current;

                    swapped = true;
                }

                // Flyttar till nästa par
                prev = swapped ? next : current;
                current = current.Next;
            }
        } while (swapped);
    }

    // Skriver ut listan
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