using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
   public class ReversOrderTests
   {
        //done: if the head is null 
        //done: if linked list have just one node 
        //done: if the linked list have more than one node 

        [TestMethod]
        public void check_revers_method_if_the_head_is_null()
        {
            //arrange
            var linked_list = new LinkedList<int>();


            //act

            var result = ReverseOrder.print_revers_order(linked_list.head);

            //assert

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void when_linked_list_have_just_one_node()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);

            //act

            var result = ReverseOrder.print_revers_order(linked_list.head);

            //assert

            Assert.AreEqual(1, result.data);

        }

        [TestMethod]
        public void when_linked_list_have_more_than_one_node()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);
            linked_list.append(4);

            //act

            var result = ReverseOrder.print_revers_order(linked_list.head);

            //assert

            while (linked_list.tail != null && result != null)
            {
                Assert.AreEqual(linked_list.tail.data, result.data);

                linked_list.tail = linked_list.tail.previous;
                result = result.next;

            }

           

        }
    }
}
