using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class CreateALinkedListForEachBinarySearchTreeDepthTest
    {
        /*         50
       *         /  \
       *        30   60
       *       /  \   \
       *      20  40   70
       *                \
       *                 80
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
            BST.insert(80);
            BST.insert(30);
            BST.insert(40);
            BST.insert(20);
            //act

            var result = CreateALinkedListForEachBinarySearchTreeDepth
                        .return_list_of_linked_list_for_BST(BST.root);

            var list_of_linked_list = new List<CodeCrack.src.linkedlist.LinkedList<int>>();

            var num_of_depth = result.Keys.Count;
            foreach (var each_value in result.Values)
            {
                list_of_linked_list.Add(each_value);
            }

            //assert
            Assert.AreEqual(num_of_depth, list_of_linked_list.Count);

        }
    }
}
