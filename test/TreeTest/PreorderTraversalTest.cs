using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingCode.src.Tree.lib;
using CrackingCode.src.Tree;

namespace CrackingCode.test.Tree
{
    [TestClass]
    public class PreorderTraversalTest
    {

        [TestMethod]
        public void print_pre_order_traversal_return_recursion()
        {
            // arrange
            Tree<int> root = new Tree<int>(50);
            var binary_search_tree = new BinarySearchTree(root);
            binary_search_tree.insert(60);
            binary_search_tree.insert(70);
            binary_search_tree.insert(80);
            binary_search_tree.insert(30);
            binary_search_tree.insert(40);
            binary_search_tree.insert(20);

            // act

            var result = PreorderTraversal
                        .print_preorder_traversal_return_recursion(binary_search_tree.root);

            var expected_result = "50 30 20 40 60 70 80 ";
            // assert 

            Assert.AreEqual(expected_result,result);

        }

        [TestMethod]
        public void print_pre_order_traversal_forward_recursion()
        {
            // arrange
            Tree<int> root = new Tree<int>(50);
            var binary_search_tree = new BinarySearchTree(root);
            binary_search_tree.insert(60);
            binary_search_tree.insert(70);
            binary_search_tree.insert(80);
            binary_search_tree.insert(30);
            binary_search_tree.insert(40);
            binary_search_tree.insert(20);

            string s = string.Empty;
            // act

            var result = PreorderTraversal
                        .print_preorder_traversal_forward_recursion(binary_search_tree.root,s);

            var expected_result = "50 30 20 40 60 70 80 ";
            // assert 

            Assert.AreEqual(expected_result, result);

        }

    }
   
}
