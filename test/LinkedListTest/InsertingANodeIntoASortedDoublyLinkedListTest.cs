using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class InsertingANodeIntoASortedDoublyLinkedListTest
    {
        //done: if the head and data are null .
        //done: if data is null return head.
        //done: if the data is less than head .
        //done: if the data must be insert middle of list .
        //done: if the data is greater than tail .

        [TestMethod]
        public void if_head_and_data_is_null()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            var data = 0;

            //act

            var result = InsertingANodeIntoASortedDoublyLinkedList
                         .inserting_a_node_into_a_sorted_doubly_linkedlist(
                             linked_list.head,
                             data
                         );

            //assert
            Assert.AreEqual(result, null);

        }

        [TestMethod]
        public void if_data_is_null_return_head()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(4);
            var data = 0;

           

            //act

            var result = InsertingANodeIntoASortedDoublyLinkedList
                         .inserting_a_node_into_a_sorted_doubly_linkedlist(
                             linked_list.head,
                             data
                         );

            //assert
            Assert.AreEqual(result, linked_list.head);

        }

        [TestMethod]
        public void if_data_is_less_than_head_data()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(4);
            var data = 2;

            var expected_result = new LinkedList<int>();
            expected_result.append(2);
            expected_result.append(3);
            expected_result.append(4);

            //act

            var result = InsertingANodeIntoASortedDoublyLinkedList
                         .inserting_a_node_into_a_sorted_doubly_linkedlist(
                             linked_list.head,
                             data
                         );

            //assert

            while (result != null && expected_result != null)
            {
                Assert.AreEqual(result.data , expected_result.head.data);

                result = result.next;
                expected_result.head = expected_result.head.next;
            }

        }

        [TestMethod]
        public void if_data_located_in_the_middle_of_list()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(4);
            linked_list.append(6);
            var data = 5;

            var expected_result = new LinkedList<int>();
            expected_result.append(3);
            expected_result.append(4);
            expected_result.append(5);
            expected_result.append(6);

            //act

            var result = InsertingANodeIntoASortedDoublyLinkedList
                         .inserting_a_node_into_a_sorted_doubly_linkedlist(
                             linked_list.head,
                             data
                         );

            //assert

            while (result != null && expected_result != null)
            {
                Assert.AreEqual(result.data, expected_result.head.data);

                result = result.next;
                expected_result.head = expected_result.head.next;
            }

        }


        [TestMethod]
        public void if_new_data_is_greater_than_tail_data()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(4);
            linked_list.append(6);
            var data = 7;

            var expected_result = new LinkedList<int>();
            expected_result.append(3);
            expected_result.append(4);
            expected_result.append(6);
            expected_result.append(7);


            //act

            var result = InsertingANodeIntoASortedDoublyLinkedList
                         .inserting_a_node_into_a_sorted_doubly_linkedlist(
                             linked_list.head,
                             data
                         );

            //assert

            while (result != null && expected_result != null)
            {
                Assert.AreEqual(result.data, expected_result.head.data);

                result = result.next;
                expected_result.head = expected_result.head.next;
            }

        }


    }
}
