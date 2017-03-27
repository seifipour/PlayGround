using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.LinkedList.test.Tests
{
    [TestClass]
    public class print_the_elements_of_a_linkedListTests
    {
        [TestMethod]
        public void chech_print_the_elements_of_a_linkedListTests()
        {

            //arraneg

            var new_linked_list = new LinkedList<int>();
            new_linked_list.append(1);
            new_linked_list.append(2);
            new_linked_list.append(3);

            //act

            var result = PrintTheElementsOfALinkedList.print(new_linked_list);
            //assert

            Assert.AreEqual("123", result);
        }
    }
}