using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class FindMergePointOfTwoListsTest
    {
        [TestMethod]
        public void both_linked_list_have_the_same_size()
        {
            //arrange
            var same_list = new LinkedList<int>();
            same_list.append(2);
            same_list.append(6);
            same_list.append(7);

            var listA = new LinkedList<int>();
            listA.append(3);
            listA.append(5);
            listA.tail.next = same_list.head;

            var listB = new LinkedList<int>();
            listB.append(1);
            listB.append(4);
            listB.tail.next = same_list.head;
            //act
            var result = FindMergePointOfTwoLists
                         .return_result(listA.head,listB.head);

            //asssert

            Assert.AreEqual(result, 2);

        }

        [TestMethod]
        public void both_linked_list_have_the_different_size()
        {
            //arrange
            var same_list = new LinkedList<int>();
            same_list.append(2);
            same_list.append(6);
            same_list.append(7);

            var listA = new LinkedList<int>();
            listA.append(3);
            listA.append(5);
            listA.append(8);
            listA.tail.next = same_list.head;

            var listB = new LinkedList<int>();
            listB.append(1);
            listB.append(4);
            listB.tail.next = same_list.head;
            var data = 0;
            //act
            var result = FindMergePointOfTwoLists
                         .return_result(listA.head, listB.head);

            //asssert

            Assert.AreEqual(result, 2);

        }
    }
}
