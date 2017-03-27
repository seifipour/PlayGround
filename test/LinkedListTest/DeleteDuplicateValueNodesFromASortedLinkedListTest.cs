using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class DeleteDuplicateValueNodesFromASortedLinkedListTest
    {
        // if head is null return null 
        // delete duplicate value from linked list 

        [TestMethod]
        public void if_head_is_null_return_null_value()
        {
            // arragne

            var linked_list = new LinkedList<int>();


            //act


            var result = DeleteDuplicateValueNodesFromASortedLinkedList
                        .delete_duplicate_value_nodes_from_a_sorted_linkedlist(linked_list.head);

            //assert

            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void delete_duplicate_value_from_linkedlist()
        {
            // arragne

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(6);
            linked_list.append(6);
            linked_list.append(5);

            var expected_linked_list = new LinkedList<int>();
            expected_linked_list.append(3);
            expected_linked_list.append(6);
            expected_linked_list.append(5);

            //act

            var result = DeleteDuplicateValueNodesFromASortedLinkedList
                        .delete_duplicate_value_nodes_from_a_sorted_linkedlist(linked_list.head);

            //assert

            while (expected_linked_list.head != null && result != null)
            {
                Assert.AreEqual(result.data, expected_linked_list.head.data);

                expected_linked_list.head = expected_linked_list.head.next;
                result = result.next;
            }
        }
    }
}
