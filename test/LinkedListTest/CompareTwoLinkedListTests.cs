using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    
   public class CompareTwoLinkedListTests
   {
        // done : if one of them is null return 0 
        // done : if one of them is longer than other return 0 
        // done : if both have the same length and have the same data return 1 
        // done : when two lists have different data .

        [TestMethod]
        public void when_one_of_the_list_is_null()
        {

            //arrange
            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(1);
            linked_list_A.append(2);
            linked_list_A.append(3);
            linked_list_A.append(4);

            var linked_list_B = new LinkedList<int>();
          

            //act

            var result = CompareTwoLinkedList
                         .copmare_two_linked_list_recursion(
                             linked_list_A.head
                           , linked_list_B.head
                         );
            //assert

            Assert.AreEqual(0, result);


        }

        [TestMethod]
        public void when_two_list_are_equal()
        {
            //arrange
            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(1);
            linked_list_A.append(2);
            linked_list_A.append(3);
            linked_list_A.append(4);

            var linked_list_B = new LinkedList<int>();
            linked_list_B.append(1);
            linked_list_B.append(2);
            linked_list_B.append(3);
            linked_list_B.append(4);

            //act

            var result = CompareTwoLinkedList
                        .copmare_two_linked_list_recursion(
                             linked_list_A.head,
                             linked_list_B.head
                        );

            //assert

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void when_one_list_is_longer_than_other_should_return_0()
        {
            //arrange
            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(1);
            linked_list_A.append(2);
            linked_list_A.append(3);
            linked_list_A.append(4);

            var linked_list_B = new LinkedList<int>();
            linked_list_B.append(1);
            linked_list_B.append(2);
            linked_list_B.append(3);
            linked_list_B.append(4);
            linked_list_B.append(5);

            //act

            var result = CompareTwoLinkedList
                        .copmare_two_linked_list_recursion(
                             linked_list_A.head,
                             linked_list_B.head
                        );

            //assert

            Assert.AreEqual(0,result);
        }

        [TestMethod]
        public void when_two_list_have_different_data()
        {
            //arrange
            var linked_list_A = new LinkedList<int>();
            linked_list_A.append(1);
            linked_list_A.append(2);
            linked_list_A.append(3);
            linked_list_A.append(4);

            var linked_list_B = new LinkedList<int>();
            linked_list_B.append(1);
            linked_list_B.append(2);
            linked_list_B.append(3);
            linked_list_B.append(7);

            //act

            var result = CompareTwoLinkedList
                        .copmare_two_linked_list_recursion(
                             linked_list_A.head,
                             linked_list_B.head
                        );

            //assert

            Assert.AreEqual(0, result);
        }
    }
}
