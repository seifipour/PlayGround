using CrackingCode.src.Tree;
using CrackingCode.src.Tree.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCode.test.TreeTest
{
    [TestClass]
    public class IsT2ASubtreeOfT1Test
    {


        /*         50   (T1)               50   (T2)        
        *         /   \                   /  \
        *        30    60                30   60
        *       /  \   / \              /  \  / \
        *      20  40 65  70           20  40 55 80                        
        *                  \                      
        *                   80                    
        *              
        */

        [TestMethod]
        public void check_balanced_tree()
        {
            //arrange
            var rootT1 = new Tree<int>(50);
            var BSTT1 = new BinarySearchTree(rootT1);
            BSTT1.insert(60);
            BSTT1.insert(70);
            BSTT1.insert(80);
            BSTT1.insert(30);
            BSTT1.insert(40);
            BSTT1.insert(20);

            var rootT2 = new Tree<int>(50);
            var BSTT2 = new BinarySearchTree(rootT2);
            BSTT2.insert(60);
            BSTT2.insert(55);
            BSTT2.insert(80);
            BSTT2.insert(30);
            BSTT2.insert(40);
            BSTT2.insert(20);

            //act

            var result = IsT2ASubtreeOfT1
                        .is_t2_subtree_of_t1(BSTT1.root,BSTT2.root);


            //assert
            Assert.AreEqual(result, false);

        }
    }
}
