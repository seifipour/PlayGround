using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{

    [TestClass]
    public class ReverseADoublyLinkedListTest
    {
        // if head is null return null 
        // if node has value revers the values

        [TestMethod]
        public void if_head_is_null_return_null()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();

            //act

            var result = ReverseADoublyLinkedList
                         .reverse_a_doubly_linkedList(linked_list_A.head);

            //assert

            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void if_node_has_two_values_reverse_the_value()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(2);
            linked_list_A.append(5);

            var expected_result = new LinkedList<int>();
            expected_result.append(5);
            expected_result.append(2);

            //act

            var result = ReverseADoublyLinkedList
                         .reverse_a_doubly_linkedList(linked_list_A.head);

            //assert
            Assert.IsNotNull(result);
            while (result != null && expected_result.head != null)
            {
                Assert.AreEqual(result.data,expected_result.head.data );
                result = result.next;
                expected_result.head = expected_result.head.next;
            }

        }

        [TestMethod]
        public void if_node_has_many_values_then_must_reverse_the_value()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(2);
            linked_list_A.append(5);
            linked_list_A.append(6);
            linked_list_A.append(12);
            linked_list_A.append(4);

            var expected_result = new LinkedList<int>();
            expected_result.append(4);
            expected_result.append(12);
            expected_result.append(6);
            expected_result.append(5);
            expected_result.append(2);

            //act

            var result = ReverseADoublyLinkedList
                         .reverse_a_doubly_linkedList(linked_list_A.head);

            //assert
            Assert.IsNotNull(result);
            while (result != null && expected_result.head != null)
            {
                Assert.AreEqual(result.data, expected_result.head.data);
                result = result.next;
                expected_result.head = expected_result.head.next;
            }

        }
    }
}
