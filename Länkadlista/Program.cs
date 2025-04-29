internal class Program
{
    private static void Main(string[] args)
    {
        // Skapar en ny länkad lista
        SingleLinkedList<int> myList = new SingleLinkedList<int>();

        // Lägger till element i listan
        myList.addFirst(5);
        myList.addFirst(3);
        myList.addFirst(4);
        myList.addFirst(1);
        myList.addFirst(2);

        // Skriver ut den ursprungliga listan
        Console.Write("Original list: ");
        myList.printList();

        // Sorterar listan med Bubble Sort
        myList.bubbleSort(Comparer<int>.Default);

        // Skriver ut den sorterade listan
        Console.Write("Sorted list: ");
        myList.printList();

        // Tar bort nod på position 2
        myList.removeNode(2);
        Console.Write("After removing node at position 2: ");
        myList.printList();

        // Tar bort den första noden
        myList.removeNode(0);
        Console.Write("After removing the first node: ");
        myList.printList();

        // Försöker ta bort en nod på en ogiltig position
        myList.removeNode(10);
    }
}