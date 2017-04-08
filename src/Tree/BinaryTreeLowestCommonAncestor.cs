using CrackingCode.src.Tree.lib;

namespace CrackingCode.src.Tree
{
    public static  class BinaryTreeLowestCommonAncestor
    {
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  40   70
        *                \ 
        *                 80
        */
        public static Tree<int> print_binary_tree_lowest_common_ancestore( Tree<int> root
                                                                         , int first_val
                                                                         , int second_val) {

            if (root == null) return null;

            if (root.data == first_val || root.data == second_val) return root;

            var left = print_binary_tree_lowest_common_ancestore(root.left, first_val, second_val);

            var right = print_binary_tree_lowest_common_ancestore(root.right, first_val, second_val);

            if (left != null && right != null) return root;

            if (left == null && right == null) return null;

            return right != null ? right : left;

        }
    }
}
