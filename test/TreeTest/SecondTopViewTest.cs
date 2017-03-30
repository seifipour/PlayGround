using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    /*         50*
   *         /    \
   *       *30    60*1
   *       /  \   /  \
   *     *20  40 55  70*2
   *        \     \    \ 
   *       27      56  80* 
   *       /        \
   *      22         57
   *     /            \
   *  *21              58
   *                    \ 
   *                    59
   */
    [TestClass]
    public class SecondTopViewTest
    {
        [TestMethod]
        public void preint_the_top_view_node_with_recursion_solution()
        {
            //arrange

            var root = new Tree<int>(50);
            var BST = new BinarySearchTree(root);
            BST.insert(60);
            BST.insert(55);
            BST.insert(56);
            BST.insert(57);
            BST.insert(58);
            BST.insert(59);
            BST.insert(70);
            BST.insert(80);
            BST.insert(30);
            BST.insert(20);
            BST.insert(40);
            BST.insert(27);
            BST.insert(22);
            BST.insert(21);


            //act
            var result = SecondTopView
                        .print_top_view_nodes_with_return_recursion(BST.root);


            var expected_result = "21 20 30 50 60 70 80 59 ";
            //assert
            Assert.AreEqual(expected_result, result);
        }
    }
}
