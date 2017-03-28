using CrackingCode.src.Tree.lib;
using System;

namespace CrackingCode.src.Tree
{

    /*          50
     *         /  \
     *        30   60
     *       /  \   \
     *      20  40   70
     *                \ 
     *                 80
     */
    public static  class HeightOfABinaryTree
    {
        public static int return_height_of_binary_tree(Tree<int> root) {
           if (root == null) return -1;

           int left_height = return_height_of_binary_tree(root.left)+1;

           int right_height =return_height_of_binary_tree(root.right)+1;

           return Math.Max(left_height,right_height);

        }
    }
}
