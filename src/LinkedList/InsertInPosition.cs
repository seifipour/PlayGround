using System;

namespace CodeCrack.src.linkedlist
{
    public static class InsertInPosition
    {


        public static Node<int> insert_a_node_at_a_specific_position_in_a_linked_list
                                               (Node<int> head
                                               , int data
                                               , int position)
        {

            var current = head;
            for (int i = 0; i < position; i++)
            {
                if (current == null) return null;
                current = current.next;
            }

            var next = current.next;

            var new_node = new Node<int>(data);
            new_node.next = next;
            new_node.previous = current;

            current.next = new_node;
            next.previous = new_node;

            return head;
        }
        
        public static Node<int> InsertNth(Node<int> head, int data, int position)
        {
            // This is a "method-only" submission. 
            // You only need to complete this method. 
            Node<int> new_node = new Node<int>(data);
            // new_node.data = data;
            Node<int> current = head;
            if (head == null) { return new_node; }

            if (position == 0) {
                new_node.next = current;
                current.previous = new_node;
                head = new_node;
                return head;
            }

            int i = 1;
            for (i=1; i<position; i++)
            {
               
                current = current.next;
            }
            if (current.next == null)
            {
                current.next = new_node;
                new_node.previous = current;
            }
            else
            {
               var temp = current.next;
                current.next = new_node;
                new_node.previous = current;
                new_node.next = temp;
                temp.previous = new_node;
            }

            return head;
        }
    }

}
