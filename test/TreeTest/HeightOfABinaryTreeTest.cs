using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class HeightOfABinaryTreeTest
    {
        [TestMethod]
        public void print_height_of_binary_tree()
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

            var result = HeightOfABinaryTree.return_height_of_binary_tree(BST.root);

            var expected_result =3;

            //assert
            Assert.AreEqual(result, expected_result);

        }
    }
}
