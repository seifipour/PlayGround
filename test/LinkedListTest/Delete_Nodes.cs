using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCrack.src.linkedlist;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class Delete_Nodes
    {
        [TestMethod]
        public void check_if_node_is_null()
        {
            //arrange

            var linked_list = new LinkedList<int>();
         
            var head = linked_list.head;

            //act

            var nodes = DeleteANode.delete_in_position(head, 1);

            //assert

            Assert.IsNull(nodes);
        }

        [TestMethod]
        public void check_when_linked_list_has_just_one_node()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);

            var head = linked_list.head;

            //act

            var nodes = DeleteANode.delete_in_position(head, 0);

            //assert

            Assert.IsNull(nodes);
        }

        [TestMethod]
        public void check_when_linked_list_has_just_more_than_one_node()
        {
            //arrange

            var linked_list = new LinkedList<int>();
            linked_list.append(1);
            linked_list.append(2);
            linked_list.append(3);
            linked_list.append(4);

            var head = linked_list.head;

            //act

            var nodes = DeleteANode.delete_in_position(head, 1);

            //assert

            Assert.AreEqual(nodes.next.data, 3);
        }

    }
}
