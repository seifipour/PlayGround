using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class GetNodeValueTest
    {
        //done :  if the head is null
        //done :  if position is less than zero 
        //done :  when position has a value in linked list 
        //done :  when position is not exist in the linkedlist


        [TestMethod]
        public void if_the_head_is_null_return_null()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            var position_from_tail = 0;

            //act

            var result = GetNodeValue.get_node_value(linked_list.head,position_from_tail);

            //assert

            Assert.AreEqual(result, 0);

        }

        [TestMethod]
        public void when_position_is_less_than_zero_return_null()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            var position_from_tail = -1;

            //act

            var result = GetNodeValue.get_node_value(linked_list.head, position_from_tail);

            //assert

            Assert.AreEqual(result, 0);

        }

        [TestMethod]
        public void check_position_2_in_linked_list_must_return_the_tail_value()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(6);
            linked_list.append(8);

            var position_from_tail = 2;

            //act

            var result = GetNodeValue.get_node_value(linked_list.head, position_from_tail);

            //assert

            Assert.AreEqual(result, 3);

        }

        [TestMethod]
        public void check_position_3_in_linked_list_must_return_0()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(3);
            linked_list.append(6);
            linked_list.append(8);

            var position_from_tail = 3;

            //act

            var result = GetNodeValue.get_node_value(linked_list.head, position_from_tail);

            //assert

            Assert.AreEqual(result, 0);

        }
    }
}
