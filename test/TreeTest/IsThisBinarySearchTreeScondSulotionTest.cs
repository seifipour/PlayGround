using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public  class IsThisBinarySearchTreeScondSulotionTest
    {
        /*        50
      *         /   \
      *        30    60
      *       /  \    \
      *      20  40    70
      *           \      \ 
      *            48    80
      *          /         \
      *         45          90
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
            BST.insert(90);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            BST.root.left.right.right = new Tree<int>(48);
            BST.root.left.right.right.left = new Tree<int>(45);
            //act

            var result = IsThisBinarySearchTreeScondSulotion
                        .is_this_binary_search_tree(BST.root);

            //assert
            Assert.AreEqual(result, false);

        }
    }
}
