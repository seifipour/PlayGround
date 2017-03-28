using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class PreorderTraversal
    {
        private static  StringBuilder string_builder= new StringBuilder();
        public static string print_preorder_traversal(Tree<int> tree) {

            if (tree != null) {

                string_builder.Append(tree.data + " ");
            }
            if (tree.left != null)
            {
                print_preorder_traversal(tree.left);
            }
            if (tree.right != null)
            {
                print_preorder_traversal(tree.right);
            }

            return string_builder.ToString();
        }
    }
}
