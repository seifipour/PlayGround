﻿using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
   public class PostorderTraversalTest
    {

        [TestMethod]
        public void Print_post_order_traversal_return_recursion()
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
            var SB = new StringBuilder();
            //act
            var result = PostorderTraversal
                        .print_post_order_traversal_return_recursion(BST.root);

            var expected_result = "20 40 30 80 70 60 50 ";
            //assert
            Assert.AreEqual(expected_result,result);

        }

        [TestMethod]
        public void Print_post_order_traversal_forward_recursion()
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

            string s = string.Empty;
            //act
            var result = PostorderTraversal
                        .print_post_order_traversal_forward_recursion(BST.root,s);

            var expected_result = "20 40 30 80 70 60 50 ";
            //assert
            Assert.AreEqual(expected_result, result);

        }
    }
}
