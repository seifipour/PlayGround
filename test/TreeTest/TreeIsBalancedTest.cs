using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class TreeIsBalancedTest
    {
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  40   70
        *               
        *                 
        *              
        */

        [TestMethod]
        public void check_balanced_tree()
        {
            //arrange
            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(70);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act

            var result = TreeIsBalanced
                        .is_tree_balanced(BST.root);


            //assert
            Assert.AreEqual(result, true);

        }


        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  40   70
        *                \
        *                 80 
        *                  \
        *                   90
        */ 


        [TestMethod]
        public void check_unbalanced_tree()
        {
            //arrange
            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(70);
            BST.insert(80);
            BST.insert(90);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act

            var result = TreeIsBalanced
                        .is_tree_balanced(BST.root);


            //assert
            Assert.AreEqual(result, false);

        }

    }
}
