using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class PreorderTraversal
    {
     /*          50
     *         /  \
     *        30   60
     *       /  \   \
     *      20  40   70
     *                \ 
     *                 80
     */
        public static string print_preorder_traversal_return_recursion(Tree<int> root) {
            string result= string.Empty;
            if (root == null) return result;

            result += root.data + " ";
            result += print_preorder_traversal_return_recursion(root.left);
            result += print_preorder_traversal_return_recursion(root.right);

            return result;
        }

        public static string print_preorder_traversal_forward_recursion(Tree<int> root
                                                                       ,string result )
        {
            if (root == null) return result;

            result += root.data + " ";
            result = print_preorder_traversal_forward_recursion(root.left, result);
            result = print_preorder_traversal_forward_recursion(root.right,result);

            return result;
        }
    }
}
