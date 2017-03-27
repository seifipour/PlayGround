using System;

namespace CodeCrack.src.linkedlist
{
    public class InsertingANodeIntoASortedDoublyLinkedList
    {

        public static void Main(string[] args)
        {

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(4);
            linked_list.append(6);

            var result = inserting_a_node_into_a_sorted_doubly_linkedlist(
                           linked_list.head,
                           7
                         );

            while (result != null)
            {

                Console.WriteLine(result.data);
                result = result.next;
            }
            Console.ReadLine();
        }

        public static Node<int> inserting_a_node_into_a_sorted_doubly_linkedlist
                                ( Node<int> head
                                , int data) {

            if (head == null) return null;
            if (data == 0) return head;

           
            var current = head;
            var is_not_appended = true;

            //append to head 
            if (head.data > data)
            {
                var new_head = new Node<int>(data);
                new_head.next = current;
                current.previous = new_head;
                head = new_head;

                return head;
            }

            //append to middle
            while (current.next != null && is_not_appended)
                {
                    if (data < current.next.data)
                    {
                        var temp = current.next.data;
                        var current_next_temp = current.next.next;

                        current.next.data = data;
                        current.next.next = new Node<int>(temp);
                        current.next.next.previous = current.next;
                        current.next.next.next = current_next_temp;

                        is_not_appended = false;
                    }
                    else {

                        current = current.next;

                    }
                }

            // append to tail 
            if (is_not_appended)
            {
                current.next = new Node<int>(data);
                current.next.previous = current;
            }
            
            return head;
        }

    }
}
