using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class TopViewTest
    {
        [TestMethod]
        public void preint_the_top_view_node_with_while_sulotion()
        {
            //arrange

            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(55);
            BST.insert(70);
            BST.insert(80);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act
            var result = TopView.print_top_view_nodes_with_while_solution(BST.root);
                       

            var expected_result = "20 30 50 60 70 80 ";
            //assert
            Assert.AreEqual(expected_result, result);
        }

        [TestMethod]
        public void preint_the_top_view_node_with_recursion_solution()
        {
            //arrange

            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(55);
            BST.insert(70);
            BST.insert(80);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act
            var result = TopView
                        .print_top_view_nodes_with_recursion(BST.root);


            var expected_result = "20 30 50 60 70 80 ";
            //assert
            Assert.AreEqual(expected_result, result);
        }
    }
}
