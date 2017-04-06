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
            
            if (root.data > Math.Max(first_val, second_val))
            {
               result= binary_search_tree_lowest_common_ancestor(root.left, first_val, second_val);
            }
            else if (root.data < Math.Min(first_val, second_val))
            {
               result =  binary_search_tree_lowest_common_ancestor(root.right, first_val, second_val);
            }
            else {
                result=root.data;
            }

            return result;
        }

    }

      
}
