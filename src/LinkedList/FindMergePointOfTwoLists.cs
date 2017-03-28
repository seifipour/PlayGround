using System;

namespace CodeCrack.src.linkedlist
{
    public class FindMergePointOfTwoLists
    {
        //public static void Main(string[] args)
        //{

        //    var linked_list_merg_point = new LinkedList<int>();
        //    linked_list_merg_point.append(3);
        //    linked_list_merg_point.append(4);

        //    var linked_list_A = new LinkedList<int>();
        //    linked_list_A.append(1);
        //    linked_list_A.append(2);
        //    linked_list_A.tail.next = linked_list_merg_point.head;

        //    var linked_list_B = new LinkedList<int>();
        //    linked_list_B.append(6);
        //    linked_list_B.append(7);
        //    linked_list_B.tail.next = linked_list_merg_point.head;

        //    var node_data = return_result(linked_list_A.head, linked_list_B.head);

        //    Console.WriteLine(node_data);
        //    Console.ReadLine();

        //}

        public static int return_result( Node<int> listA
                                       , Node<int> listB )
        {
            var size_of_listA= return_size_of_list(listA);
            var size_of_list_B = return_size_of_list(listB);

            var get_the_max_size = Math.Max(size_of_listA, size_of_list_B);

            Node<int> currentA = create_same_size(listA, size_of_listA, get_the_max_size);
            Node<int> currentB = create_same_size(listB, size_of_list_B, get_the_max_size);

            var result = find_the_merg_data(currentA, currentB);

            return result;    
        }

        public static int find_the_merg_data( Node<int> nodeA
                                            , Node<int> nodeB ) {

         if (nodeA == null || nodeB == null) throw new Exception("No merge point");

         if (nodeA == nodeB && nodeA.data == nodeB.data) return nodeA.data;

         var result = find_the_merg_data(nodeA.next, nodeB.next);

         return result;
        }

        public static int return_size_of_list(Node<int> list_A ) {

           if (list_A == null) return 0;
           var total = return_size_of_list(list_A.next) + 1;
            return total;
        }

        public static Node<int> create_same_size( Node<int> nodes
                                                , int size_of_list 
                                                , int max_size ) {

            Node<int> current = nodes;
            if (size_of_list == max_size) { return current; }

            else if(max_size !=0) {
                var new_head = new Node<int>(0);
                new_head.next = current;
                current = new_head;
                size_of_list++;
            }

             create_same_size(current.next, size_of_list, max_size);

            return current;

        }


    }
}
