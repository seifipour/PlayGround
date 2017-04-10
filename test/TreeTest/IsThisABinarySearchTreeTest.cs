using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class IsThisABinarySearchTreeTest
    {
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  60   70
        *                \ 
        *                 80
        */

        [TestMethod]
        public void is_this_a_binary_search_tree()
        {
            //arrange
            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(70);
            BST.insert(80);
            BST.insert(30);
            BST.insert(60);
            BST.insert(20);
          
            //act

            var result = IsThisABinarySearchTree
                        .is_this_binary_search_tree(BST.root);

            var expected_result =false;

            //assert
            Assert.AreEqual(result, expected_result);

        }
    }
}
