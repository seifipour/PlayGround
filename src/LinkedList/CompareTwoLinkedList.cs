using System;
namespace CodeCrack.src.linkedlist
{

    public class CompareTwoLinkedList
    {
        //public static void Main(string[] args)
        //{

        //    var linked_list_A = new LinkedList<int>();
        //    linked_list_A.append(1);
        //    linked_list_A.append(2);
        //    linked_list_A.append(3);
        //    linked_list_A.append(4);

        //    var linked_list_B = new LinkedList<int>();
        //    linked_list_B.append(1);
        //    linked_list_B.append(2);
        //    linked_list_B.append(7);
        //    linked_list_B.append(4);

        //    var result = copmare_two_linked_list_recursion(
        //                     linked_list_A.head,
        //                     linked_list_B.head
        //                );

        //    Console.WriteLine(result);
        //    Console.Read();

        //}

        public static int copmare_two_linked_list( Node<int> first, Node<int> second) {

            if (first == null) return 0;
            if (second == null) return 0;

            while (first != null && second != null)
            {
                if (first.data != second.data)
                {
                    return 0;
                }
             
                first = first.next;
                second = second.next;
            }

            if (first != null || second != null)
            {
                return 0;
            }

            return 1;
        }

        public static  int result = 0;
        public static int copmare_two_linked_list_recursion(Node<int> first, Node<int> second)
        {
            if (first == null && second == null) return result;
            if (first != null && second == null) return result = 0; 
            if (first == null && second != null) return result = 0;

            if (first.data != second.data)
            {
                return result=0;
            }
            else {
                result = 1;
            }

            first = first.next;
            second = second.next;

            result= copmare_two_linked_list_recursion(first, second);

            return result;
        }
    }
}
