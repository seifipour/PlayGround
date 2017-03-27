using System;
using System.Text;

namespace CodeCrack.src.linkedlist
{
    public static class PrintTheElementsOfALinkedList
    {
        public static void Main(string[] args)
        {

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);

            var nodes = print(linked_list);
            foreach (var each_char in nodes.ToCharArray())
            {

                Console.WriteLine(each_char);
            }
            Console.ReadLine();

        }
        public static string print(LinkedList<int> linked_list)
        {
            if (linked_list.head == null) return string.Empty;

            var current = linked_list.head;
            var string_builder = new StringBuilder();

            while (current != null)
            {
                string_builder.Append(current.data);
                current = current.next;
            }

            return string_builder.ToString();
        }

     
    }
}
