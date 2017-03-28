using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class InorderTraversal
    {
        private static StringBuilder result = new StringBuilder();
        public static string print_inorder_traversal(Tree<int> root)
        {
            if (root == null) return result.ToString();

            if (root.left != null) {
                print_inorder_traversal(root.left);
            }
            result.Append(root.data + " ");

            if (root.right != null)
            {
                print_inorder_traversal(root.right);
            }

            return result.ToString();
        }

    }
}
