using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class InorderTraversal
    {
    /*          50
     *         /  \
     *        30   60
     *       /  \   \
     *      20  40   70
     *                \ 
     *                 80
     */
        public static string print_inorder_traversal(Tree<int> root)
        {
            var result = string.Empty;
           if (root == null) return result;
            result +=  print_inorder_traversal(root.left);
            result += root.data.ToString()+" "; 
            result += print_inorder_traversal(root.right);
            return result;
        }

    }
}
