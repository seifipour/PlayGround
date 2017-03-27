using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class MergeTwoSortedLinkedListsTest
    {
        // to_do : if both list is null
        // to_do : if one of list is null 
        // to_do : if the two list have different values 
        // to_do : if second list have the same value of the first list 

        [TestMethod]
        public void if_both_list_are_null()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();
            var linked_list_B = new LinkedList<int>();

            //act

            var result= MergeTwoSortedLinkedLists
                       .merge_two_sorted_linked_list(
                           linked_list_A.head,
                           linked_list_B.head
                       );

            //assert

            Assert.AreEqual(null , result);
        }

        [TestMethod]
        public void if_one_of_the_lists_is_null()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();
            var linked_list_B = new LinkedList<int>();
            linked_list_B.append(1);
            linked_list_B.append(2);

            //act

            var result = MergeTwoSortedLinkedLists
                       .merge_two_sorted_linked_list(
                           linked_list_A.head,
                           linked_list_B.head
                       );

            //assert

            Assert.AreEqual(linked_list_B.head, result);
        }

        [TestMethod]
        public void if_second_list_have_the_different_value_of_the_first_list()
        {
            //arrange

            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(3);
            linked_list_A.append(6);

            var linked_list_B = new LinkedList<int>();
            linked_list_B.append(1);
            linked_list_B.append(2);

            var expected_result = new LinkedList<int>();
            expected_result.append(1);
            expected_result.append(2);
            expected_result.append(3);
            expected_result.append(6);

            //act

            var result = MergeTwoSortedLinkedLists
                       .merge_two_sorted_linked_list(
                           linked_list_A.head,
                           linked_list_B.head
                       );

            //assert
            while (expected_result.head.next != null && result.next != null) {

                Assert.AreEqual(expected_result.head.data , result.data);
                result = result.next;
                expected_result.head = expected_result.head.next;
            }
        }



    }
}
