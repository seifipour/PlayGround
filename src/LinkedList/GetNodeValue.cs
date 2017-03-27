using System;

namespace CodeCrack.src.linkedlist
{
    public class GetNodeValue
   {
        public static void Main(string[] args)
        {

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(6);
            linked_list.append(5);

            // position start from 0 
            var result = get_node_value(linked_list.head, 2);

            Console.WriteLine(result);
            Console.Read();
        }

        public static int get_node_value(Node<int> head, int position_from_tail) {

            if (head == null) return 0;
            if (position_from_tail < 0) return 0;

            var fast_runner = head;
            var slow_runner = head;
            var index = 0;
            var number_of_nodes = 0;
            while (fast_runner != null)
            {
                fast_runner = fast_runner.next;
                number_of_nodes++;
                if (index++ > position_from_tail)
                {
                    slow_runner = slow_runner.next;
                }

            }
            if (number_of_nodes <= position_from_tail) return 0;

            return slow_runner.data;
        }
   }
}
