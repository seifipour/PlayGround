﻿using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class BinarySearchTreeLowestCommonAncestorTest
    {
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  40   70
        *                \ 
        *                 80
        */

        [TestMethod]
        public void print_common_ancestor_between_20_and_80()
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

            var result = BinarySearchTreeLowestCommonAncestor
                        .binary_search_tree_lowest_common_ancestor(BST.root,20,80);
            var actual_result = "LCA of 20 and 80 is " + result;

            var expected_result = "LCA of 20 and 80 is 50";

            //assert
            Assert.AreEqual(actual_result,expected_result);

        }

        [TestMethod]
        public void print_common_ancestor_between_20_and_30()
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

            var result = BinarySearchTreeLowestCommonAncestor
                        .binary_search_tree_lowest_common_ancestor(BST.root, 20, 30);
            var actual_result = "LCA of 20 and 80 is " + result;

            var expected_result = "LCA of 20 and 80 is 30";

            //assert
            Assert.AreEqual(actual_result, expected_result);

        }
    }
}
