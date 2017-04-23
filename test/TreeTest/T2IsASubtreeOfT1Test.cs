using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class T2IsASubtreeOfT1Test
    {
        /*          50                 70   
         *         /  \               /  \ 
         *        30   60            65   80
         *       /  \   \
         *      20  40   70
         *              /  \ 
         *             65   80
         */

        [TestMethod]
        public void check_t2_is_subtree_of_t1()
        {
            //arrange
            var rootT1 = new Tree<int>(50);
            var BSTT1 = new BinarySearchTree(rootT1);
            BSTT1.insert(60);
            BSTT1.insert(70);
            BSTT1.insert(65);
            BSTT1.insert(80);
            BSTT1.insert(30);
            BSTT1.insert(40);
            BSTT1.insert(20);

            var rootT2 = new Tree<int>(70);
            var BSTT2 = new BinarySearchTree(rootT2);
            BSTT2.insert(65);
            BSTT2.insert(80);
            //act

            var result = IsT2ASubtreeOfT1
                         .is_t2_subtree_of_t1(BSTT1.root,BSTT2.root);

            //assert
            Assert.AreEqual(result, true);

        }
    }
}
