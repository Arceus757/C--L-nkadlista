internal class Program
{
    private static void Main(string[] args)
    {
        SingleLinkedList<int> myList = new SingleLinkedList<int>();

        myList.addFirst(5);
        myList.addFirst(4);
        myList.addFirst(3);
        myList.addFirst(2);
        myList.addFirst(1);

        Console.Write("Original list: ");
        myList.printList();

        myList.removeNode(2); // Remove node at position 2
        Console.Write("After removing node at position 2: ");
        myList.printList();

        myList.removeNode(0); // Remove first node
        Console.Write("After removing first node: ");
        myList.printList();

        myList.removeNode(10); // Invalid position
    }
}
