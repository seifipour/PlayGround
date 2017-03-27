using System;

namespace CodeCrack.src.linkedlist
{
    public class ReverseADoublyLinkedList
    {

        public static void Main(string[] args)
        {

            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(1);
            linked_list_A.append(2);
            linked_list_A.append(3);
            linked_list_A.append(4);
            linked_list_A.append(5);

            var result = reverse_a_doubly_linkedList(linked_list_A.head);

            while (result != null)
            {
                Console.WriteLine(result.data);
                result = result.next;
            }

            Console.ReadLine();

        }

        public static Node<int> reverse_a_doubly_linkedList(Node<int> head) {

            if (head == null) return null;

            Node<int> reverse_node= null;

            while (head != null)
            {

                if (reverse_node == null)
                {
                    reverse_node = new Node<int>(head.data);
                }
                else {
                    var new_node = new Node<int>(head.data);
                    new_node.next = reverse_node;
                    reverse_node.previous = new_node;
                    reverse_node = new_node;
                }

                head = head.next;
            }
            
            return reverse_node;
        }
    }
}
