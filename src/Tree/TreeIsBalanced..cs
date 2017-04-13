using CrackingCode.src.Tree.lib;
using System;

namespace CrackingCode.src.Tree
{
    public static class TreeIsBalanced
    {
        /*          50
         *         /  \
         *        30   60
         *       /  \   \
         *      20  40   70
         *                
         */

        public static bool is_tree_balanced(Tree<int> root)
        {
            if (root == null) return false;

            if (check_tree_is_balanced(root) > -1) return true;

            return false;
        }
       
        public static int check_tree_is_balanced(Tree<int> root)
        {
            if (root == null) return 0;

            int left_h = check_tree_is_balanced(root.left);
            int right_h = check_tree_is_balanced(root.right);                       

            if (left_h == -1 || right_h == -1) return -1;
            if (Math.Abs(left_h - right_h) > 1) return -1;

            if (left_h > right_h) return left_h + 1;

            return right_h + 1;

        }
    }
}
