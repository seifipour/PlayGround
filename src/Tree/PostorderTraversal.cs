using CrackingCode.src.Tree.lib;
using System.Text;

namespace CrackingCode.src.Tree
{
    public static class PostorderTraversal
    {
        public static string print_post_order_traversal( Tree<int> root
                                                       , StringBuilder string_builder)
        {
            if (root == null) return string_builder.ToString();

            if (root.left != null)
            {
                print_post_order_traversal(root.left ,string_builder);
            }
            if (root.right != null)
            {
                print_post_order_traversal(root.right,string_builder);
            }

            string_builder.Append(root.data+" ");

            return string_builder.ToString();

        }
    }
}
