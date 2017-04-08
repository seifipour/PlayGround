using CrackingCode.src.Tree.lib;
using System;
using System.Collections.Generic;

namespace CrackingCode.src.Tree
{
    public class BinarySearchTreeLowestCommonAncestor
    {
        public static void Main(string[] arg) { }
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  40   70
        *                \ 
        *                 80
        */
        public static int binary_search_tree_lowest_common_ancestor
                                        ( Tree<int> root
                                        , int first_val
                                        , int second_val)
        {
            var result = 0;
            if (root == null) return result;

            var max = Math.Max(first_val, second_val);
            var min = Math.Min(first_val, second_val);

            if (root.data <= max && root.data >= min)
            {
                return root.data;
            }
            else {

                Tree<int> next = (root.data > max) ? root.left : root.right;
                return binary_search_tree_lowest_common_ancestor(next, first_val, second_val);
            }

        }
    }
}
