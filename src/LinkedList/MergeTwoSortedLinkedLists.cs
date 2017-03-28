using System;

namespace CodeCrack.src.linkedlist
{
    public class MergeTwoSortedLinkedLists
    {
        //public static void Main(string[] arg)
        //{

        //    var linked_list_A = new LinkedList<int>();
        //    linked_list_A.append(3);
        //    linked_list_A.append(6);
        //    linked_list_A.append(5);

        //    var linked_list_B = new LinkedList<int>();
        //    linked_list_B.append(1);
        //    linked_list_B.append(2);
        //    linked_list_B.append(4);

        //    var result = merge_two_sorted_linked_list(
        //                       linked_list_A.head,
        //                       linked_list_B.head
        //                 );

        //    while (result != null)
        //    {
        //        Console.WriteLine(result.data);
        //        result = result.next;
        //    }

        //    Console.ReadLine();

        //}
        public static Node<int> merge_two_sorted_linked_list
                                    ( Node<int> nodes_A
                                    , Node<int> nodes_B ) {

            if ( nodes_A == null && nodes_B == null ) return null;
            if ( nodes_A != null && nodes_B == null ) return nodes_A;
            if ( nodes_B != null && nodes_A == null ) return nodes_B;

            var new_linked_list = new LinkedList<int>();

            while (nodes_A != null && nodes_B != null)
            {
                if (nodes_A.data < nodes_B.data)
                {
                    new_linked_list.append(nodes_A.data);

                    if (nodes_A.next != null && nodes_B.data > nodes_A.next.data)
                    {
                        new_linked_list.append(nodes_A.next.data);
                        nodes_A.next.data = nodes_B.data;
                    }
                    else {
                        new_linked_list.append(nodes_B.data);
                    }
                }
                else {

                    new_linked_list.append(nodes_B.data);

                    if (nodes_B.next != null && nodes_A.data > nodes_B.next.data)
                    {
                        new_linked_list.append(nodes_B.next.data);
                        nodes_B.next.data = nodes_A.data;
                    }
                    else  {
                        new_linked_list.append(nodes_A.data);
                    }
                }

                nodes_A = nodes_A.next;
                nodes_B = nodes_B.next;
            }

            return new_linked_list.head;
        }
    }
}
