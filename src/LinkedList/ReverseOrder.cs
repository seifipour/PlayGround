using System;

namespace CodeCrack.src.linkedlist
{
    public class ReverseOrder
    {
        public static void Main(string[] args)
        {

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);
            linked_list.append(4);

            var head = linked_list.head;
            var nodes = print_revers_order(head);

            while (nodes != null)
            {
                Console.WriteLine(string.Join(" ", nodes.data));
                nodes = nodes.next;
            }

            Console.ReadLine();
        }

        public static Node<int> print_revers_order(Node<int> current) {

            if (current == null ) return null;
            if (current.next == null) return current;

            var linked_list = new LinkedList<int>();

            while (current != null) {

                if (linked_list.tail == null)
                {
                    linked_list.tail = new Node<int>(current.data);
                }
                else if (linked_list.head == null)
                {
                    linked_list.head = new Node<int>(current.data);
                    linked_list.head.next = linked_list.tail;
                    linked_list.tail.previous = linked_list.head;
                }
                else {
                    var new_head = new Node<int>(current.data);
                    var temp = linked_list.head;
                    linked_list.head = new_head;
                    new_head.next = temp;
                    temp.previous = new_head;
                }

                current = current.next;
            }
            return linked_list.head;


        }

    }
}
