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
        public static string print_inorder_traversal_return_recursion(Tree<int> root)
        {
            var result = string.Empty;
           if (root == null) return result;
            result += print_inorder_traversal_return_recursion(root.left);
            result += root.data.ToString()+" "; 
            result += print_inorder_traversal_return_recursion(root.right);
            return result;
        }

        public static string print_inorder_traversal_forward_recursion(Tree<int> root
                                                                      , string result)
        {
            if (root == null) return result;
            result = print_inorder_traversal_forward_recursion(root.left, result);
            result += root.data.ToString() + " ";
            result = print_inorder_traversal_forward_recursion(root.right,result);
            return result;
        }
        

    }
}
