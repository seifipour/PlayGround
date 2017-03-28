using System;

namespace CodeCrack.src.linkedlist
{
    public static  class DeleteANode
    {
        //public static void Main(string[] args)
        //{

        //    var linked_list = new LinkedList<int>();
        //    linked_list.append(1);
        //    linked_list.append(2);
        //    linked_list.append(3);
        //    linked_list.append(4);

        //    var head = linked_list.head;
        //    var nodes = delete_in_position(head, 1);

        //    while (nodes != null)
        //    {
        //        Console.WriteLine(string.Join(" ", nodes.data));
        //        nodes = nodes.next;
        //    }

        //    Console.ReadLine();

        //}

        public static Node<int> delete_in_position(Node<int> node, int position) {

            if (node == null || position <= 0 ) return null;

            var current = node;

            for (int i =1; i< position; i++) {

                current = current.next;
            }

            while (current.next.next != null)
            {
                current.data = current.next.data;
                current = current.next;
            }

            current.data = current.next.data;
            current.next = current.next.next;

            return node;
        }
    }
}
