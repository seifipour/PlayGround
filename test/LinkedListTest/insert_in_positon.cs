using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCrack.src.linkedlist;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class insert_in_positon
    {
        [TestMethod]
        public void chech_if_head_is_null__insert_in_position()
        {
            //arrange

            var linked_list = new LinkedList<int>();

            //act

            var result = InsertInPosition
                .insert_a_node_at_a_specific_position_in_a_linked_list(
                   head: null,
                   data: 1,
                   position: 2
                );

            //assert

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void chech_if_the_position_is_out_of_range_insert_in_position()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);

            //act

            var result = InsertInPosition
                .insert_a_node_at_a_specific_position_in_a_linked_list(
                   head: linked_list.head,
                   data: 1,
                   position: 5
                );

            //assert

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void chech_insert_in_position()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);

            //act

            var result = InsertInPosition
                .insert_a_node_at_a_specific_position_in_a_linked_list(
                   head: linked_list.head,
                   data: 5,
                   position: 1
                );

            //assert

           Assert.AreEqual(linked_list.head.next.next, result.next.next);
        }
    }
}
