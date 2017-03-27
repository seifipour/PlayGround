using System;

namespace CodeCrack.src.linkedlist
{
    public class SumOFLinkedListWhenOneIsRight
    {

        public static void Main(string[] args)
        {
            var first = new LinkedList<int>();
            first.append(1);
            first.append(1);
            first.append(0);

            var second = new LinkedList<int>();
            second.append(2);
            second.append(2);
            second.append(0);

            var result = sum_of_two_linked_list_when_ones_in_right_return_recursion(
                            first,
                            second
                         );
            while (result.head != null)
            {
                Console.WriteLine(result.head.data);

                result.head = result.head.next;
            }

            Console.ReadLine();
        }


        public static LinkedList<int> sum_of_two_linked_list_when_ones_in_right_return_recursion
                                         ( LinkedList<int> first
                                         , LinkedList<int> second)
        {

            var new_linked_list = new LinkedList<int>();
            var first_size = size(first.head);
            var second_size = size(second.head);
            var carry_over = 0;
            LinkedList<int> linked_list = new LinkedList<int>();
            if (first_size > second_size)
            {
                var differ_between_first_and_second = first_size - second_size;
                var second_linked_list = create_same_size_form_head(
                                               linked_list: second,
                                               size: differ_between_first_and_second
                                             );

                new_linked_list = sum_of_two_list_when_ones_is_right_with_retun_recursion(
                                    first.head,
                                    second_linked_list.head,
                                    carry_over)
                                  ._linked_list;
            }
            else
            {

                var differ_between_second_and_first = second_size - first_size;
                var first_linked_list = create_same_size_form_head(
                                               linked_list: first,
                                               size: differ_between_second_and_first
                                             );

                new_linked_list = sum_of_two_list_when_ones_is_right_with_retun_recursion(
                                    first_linked_list.head,
                                    second.head,
                                    carry_over)
                                   ._linked_list;

            }

            return new_linked_list;
        }

        public static LinkedList<int> sum_of_two_linked_list_when_ones_in_right_forward_recursion
                                        (LinkedList<int> first
                                        , LinkedList<int> second)
        {

            var new_linked_list = new LinkedList<int>();
            var first_size = size(first.head);
            var second_size = size(second.head);
            var carry_over = 0;
            LinkedList<int> linked_list = new LinkedList<int>();
            if (first_size > second_size)
            {
                var differ_between_first_and_second = first_size - second_size;
                var second_linked_list = create_same_size_form_head(
                                               linked_list: second,
                                               size: differ_between_first_and_second
                                             );

                new_linked_list = sum_of_two_list_when_ones_is_right_with_forward_recursion(
                                    first.head,
                                    second_linked_list.head,
                                    carry_over,
                                    linked_list)
                                  ._linked_list;
            }
            else
            {

                var differ_between_second_and_first = second_size - first_size;
                var first_linked_list = create_same_size_form_head(
                                               linked_list: first,
                                               size: differ_between_second_and_first
                                             );

                new_linked_list = sum_of_two_list_when_ones_is_right_with_forward_recursion(
                                    first_linked_list.head,
                                    second.head,
                                    carry_over,
                                    linked_list)
                                   ._linked_list;

            }

            return new_linked_list;
        }


        public static Sum sum_of_two_list_when_ones_is_right_with_forward_recursion
                                              ( Node<int> first
                                              , Node<int> second
                                              , int carry_over
                                              , LinkedList<int> new_linked_list)
        {
            
            int sum = 0;
            if (first == null && second == null) return new Sum();

            var result = sum_of_two_list_when_ones_is_right_with_forward_recursion(
                              first.next,
                              second.next,
                              carry_over,
                              new_linked_list);

            sum = (first.data + second.data) + result._carry_over;

            if (new_linked_list.head == null)
            {
                new_linked_list.append(sum % 10);
            }
            else
            {
                new_linked_list.prepend(sum % 10);
            }
            carry_over = sum / 10;
            result.CarryOver = carry_over;

            if (first.previous == null && second.previous == null && result._carry_over != 0)
            {
                new_linked_list.prepend(result.CarryOver);
            }
            
            result._linked_list = new_linked_list;
            return result;
        }

        public static Sum sum_of_two_list_when_ones_is_right_with_retun_recursion
                                           ( Node<int> first
                                           , Node<int> second
                                           , int carry_over)
        {

            //1783
            //0069
            if (first == null && second == null) return new Sum();

            var total = sum_of_two_list_when_ones_is_right_with_retun_recursion(
                               first.next,
                               second.next,
                               carry_over
                         );

            var sum = (first.data + second.data) + total.CarryOver;
            total.CarryOver = sum / 10;
            sum %= 10;

            if (total.Linked_list == null)
            {
                total.Linked_list = new LinkedList<int>();
                total.Linked_list.head = new Node<int>(sum);
            }
            else
            {
                var new_head = new Node<int>(sum);
                var temp = total.Linked_list.head;
                new_head.next = temp;
                total.Linked_list.head = new_head;
            }
            if (first.previous == null && second.previous == null && total.CarryOver != 0)
            {

                var new_head = new Node<int>(total.CarryOver);
                var temp = total.Linked_list.head;
                new_head.next = temp;
                total.Linked_list.head = new_head;
            }

            return total;
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

        public static LinkedList<int> create_same_size_form_head
                                            (LinkedList<int> linked_list
                                            , int size)
        {

            var new_linked_list = new LinkedList<int>();

            while (size != 0)
            {
                new_linked_list.append(0);
                size--;
            }
            while (linked_list.head != null)
            {
                new_linked_list.append(linked_list.head.data);
                linked_list.head = linked_list.head.next;
            }

            return new_linked_list;
        }

    }

    public class Sum
    {

        public LinkedList<int> _linked_list;
        public int _carry_over;

        public LinkedList<int> Linked_list
        {

            get { return _linked_list; }
            set { _linked_list = value; }
        }

        public int CarryOver
        {
            get { return _carry_over; }
            set { _carry_over = value; }
        }

    }
}
