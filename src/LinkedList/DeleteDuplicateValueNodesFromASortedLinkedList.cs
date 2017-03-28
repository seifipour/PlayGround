using System;
using System.Collections.Generic;

namespace CodeCrack.src.linkedlist
{
    public class DeleteDuplicateValueNodesFromASortedLinkedList
    {
        //public static void Main(string[] args)
        //{

        //    var linked_list = new LinkedList<int>();
        //    linked_list.append(3);
        //    linked_list.append(6);
        //    linked_list.append(6);
        //    linked_list.append(5);

        //    var result = delete_duplicate_value_nodes_from_a_sorted_linkedlist(linked_list.head);

        //    while (result != null)
        //    {
        //        Console.Write(result.data);
        //        result = result.next;
        //    }

        //    Console.Read();
        //}

        public static Node<int> delete_duplicate_value_nodes_from_a_sorted_linkedlist(Node<int> head) {

            if (head == null) return null;

            var hash_set = new HashSet<int>();
            var current = head;
            var linked_list_without_duplicate_value= new LinkedList<int>();

            while (current != null)
            {
                if (!hash_set.Contains(current.data)) {

                    hash_set.Add(current.data);
                    linked_list_without_duplicate_value.append(current.data);
                }
                current = current.next;
            }

            return linked_list_without_duplicate_value.head;
        }
    }
}
