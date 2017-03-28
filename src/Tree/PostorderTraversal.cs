using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class PostorderTraversal
    {
     /*          50
     *         /  \
     *        30   60
     *       /  \   \
     *      20  40   70
     *                \ 
     *                 80
     */
        public static string print_post_order_traversal( Tree<int> root)
        {
            var result = string.Empty;
            if (root == null) return result;

              result += print_post_order_traversal(root.left );
              result += print_post_order_traversal(root.right);
              result += root.data+" ";

            return result;

        }
    }
}
