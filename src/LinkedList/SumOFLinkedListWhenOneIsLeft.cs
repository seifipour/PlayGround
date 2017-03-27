using System;

namespace CodeCrack.src.linkedlist
{
    public class SumOFLinkedListWhenOneIsLeft
    {

        //left 1 7 8 3 right
        //left 0 0 6 9  right
        public static void Main(string[] args)
        {

            var new_linked_list = new LinkedList<int>();
            var first = new LinkedList<int>();
            first.append(3);
            first.append(8);
            first.append(7);
            first.append(1);

            var second = new LinkedList<int>();
            second.append(9);
            second.append(6);

            var result_for_return_recursion = sum_of_two_linked_list_when_ones_is_left_with_return_recursion(
                                                 first,
                                                 second
                                             );

            while (result_for_return_recursion.head.next != null)
            {

                Console.WriteLine(result_for_return_recursion.head.data);

                result_for_return_recursion.head = result_for_return_recursion.head.next;
            }

            Console.ReadLine();
        }

        public static LinkedList<int> sum_of_two_linked_list_when_ones_is_left_with_return_recursion
                                       ( LinkedList<int> first
                                       , LinkedList<int> second)
        {

            var new_linked_list = new LinkedList<int>();
            var first_list = first.head;
            var second_list = second.head;

            var first_size = size(first_list);
            var second_size = size(second_list);
            var carry_over = 0;
            LinkedList<int> linked_list = new LinkedList<int>();
            if (first_size > second_size)
            {
                var second_linked_list = create_same_size(second, first_size);
                new_linked_list = sum_of_two_list_when_ones_is_left_return_recusrion(
                                     first.head,
                                     second_linked_list.head,
                                     carry_over)
                                     ;

            }
            else
            {

                var first_linked_list = create_same_size(first, second_size);
                new_linked_list = sum_of_two_list_when_ones_is_left_return_recusrion(
                                        first_linked_list.head
                                      , second.head
                                      , carry_over);
            }

            return new_linked_list;
        }

        public static LinkedList<int> sum_of_two_list_when_ones_is_left_return_recusrion
                                   (Node<int> first
                                   , Node<int> second
                                   , int carry_over)
        {

            if (first == null && second == null)
            {
                var result = new LinkedList<int>();
                if (carry_over != 0)
                {
                    result.append(carry_over);
                }
                return result;
            }

            var sum = (first.data + second.data) + carry_over;
            carry_over = sum / 10;
            sum = sum % 10;

            var total = sum_of_two_list_when_ones_is_left_return_recusrion(
                            first.next,
                            second.next,
                            carry_over
                        );

            total.prepend(sum);

            return total;
        }

        public static LinkedList<int> sum_of_two_linked_list_when_ones_is_left_with_forward_recursion
                                     ( LinkedList<int> first
                                     , LinkedList<int> second)
        {

            var new_linked_list = new LinkedList<int>();
            var first_list = first.head;
            var second_list = second.head;

            var first_size = size(first_list);
            var second_size = size(second_list);
            var carry_over = 0;
            LinkedList<int> linked_list = new LinkedList<int>();
            if (first_size > second_size)
            {
                var second_linked_list = create_same_size(second, first_size);
                new_linked_list = sum_of_two_list_when_ones_is_left_with_forward_recursion(
                                     first.head,
                                     second_linked_list.head,
                                     carry_over,
                                     linked_list);

            }
            else
            {

                var first_linked_list = create_same_size(first, second_size);
                new_linked_list = sum_of_two_list_when_ones_is_left_with_forward_recursion(
                                        first_linked_list.head
                                      , second.head
                                      , carry_over
                                      , linked_list);
            }

            return new_linked_list;
        }

        public static LinkedList<int> sum_of_two_list_when_ones_is_left_with_forward_recursion
                                    ( Node<int> first
                                    , Node<int> second
                                    , int carry_over
                                    , LinkedList<int> new_linked_list)
        {
            if (first == null && second == null)
            {
                if (carry_over != 0)
                {
                    new_linked_list.append(carry_over);
                }
            }
            else
            {
                var sum = (first.data + second.data) + carry_over;
                carry_over = sum / 10;
                sum = sum % 10;
                new_linked_list.append(sum);

                sum_of_two_list_when_ones_is_left_with_forward_recursion(
                                first.next,
                                second.next,
                                carry_over,
                                new_linked_list);
            }
           
            return new_linked_list;
        }

        public static LinkedList<int> create_same_size(LinkedList<int> linked_list, int size)
        {

            var new_linked_list = new LinkedList<int>();

            while (size != 0)
            {
                new_linked_list.append(linked_list.head.data);

                if (linked_list.head.next == null)
                {
                    linked_list.head.next = new Node<int>(0);
                }

                linked_list.head = linked_list.head.next;
                size--;
            }

            return new_linked_list;
        }

        public static int size(Node<int> head)
        {
            var count = 0;
            while (head != null)
            {
                head = head.next;
                count++;
            }

            return count;
        }


    }

}
