using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class LevelOrderTraversalTest
    {
        /*         50        level 1
        *         /   \
        *        30   60     level 2
        *       /  \    \
        *      20  40    70  level 3
        *                  \ 
        *                  80* level 4 
        */
        [TestMethod]
        public void print_level_order_traversal()
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

            var result =  LevelOrderTraversal.print_level_order_traversal(BST.root);

            var expected_result ="50 30 60 20 40 70 80 ";

            //assert
            Assert.AreEqual(result, expected_result);

        }
    }
}
