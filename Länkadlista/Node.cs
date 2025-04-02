class Node<T> {
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T Data, Node<T> Next = null) {
        this.Data = Data;
        this.Next = Next;
    }
} 