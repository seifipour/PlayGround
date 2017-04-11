using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class ConverSortedListToBinarySearchTreeTest
    {
        //{20,30,40,50,60,70,80}

        [TestMethod]
        public void is_this_a_binary_search_tree()
        {
            //arrange
            var expected_result = new List<int> { 2, 5, 7, 10, 12 };
            //act
            Tree<int> root = null;
            var result = ConverSortedListToBinarySearchTree
                        .convert_sorted_list_to_binary_search_tree(
                               sorted_list:  expected_result,
                               start: 0,
                               end: expected_result.Count-1,
                               root: root);

            var actual_datas = ConverSortedListToBinarySearchTree
                .print_inorder_traversal(result , new List<int>());

            //assert
            Assert.AreEqual(actual_datas.Count, expected_result.Count);

        }
    }
}
