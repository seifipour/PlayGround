namespace CodeCrack.src.linkedlist
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node<T> previous;
        public Node(T data)
        {

            this.data = data;
        }
    }
    public class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public void append(T data) {

            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else {
                tail.next = new Node<T>(data);
                tail.next.previous = tail;
                tail = tail.next;
            }
        }

        public void prepend(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }
            var new_head = new Node<T>(data);
            new_head.next = head;
            head = new_head;
        }

       
    }
}
