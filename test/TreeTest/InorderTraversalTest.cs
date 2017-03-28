using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class InorderTraversalTest
    {
        [TestMethod]
        public void check_print_of_inorder_traversal()
        {
            //arrange
            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(70);
            BST.insert(80);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act

            var result = InorderTraversal.print_inorder_traversal(BST.root);

            var expected_result = "20 30 40 50 60 70 80 ";

            //assert
            Assert.AreEqual(expected_result, result);

        }
    }
}
