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
        public static string print_preorder_traversal(Tree<int> root) {
            string result= string.Empty;
            if (root == null) return result;

            result += root.data + " ";
            result += print_preorder_traversal(root.left);
            result += print_preorder_traversal(root.right);

            return result;
        }
    }
}
