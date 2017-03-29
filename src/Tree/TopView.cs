using CrackingCode.src.Tree.lib;
using System.Collections;

namespace CrackingCode.src.Tree
{
    public static  class TopView
    {
       /*         50
       *         /   \
       *        30    60
       *       /  \   / \
       *      20  40 55  70
       *                  \ 
       *                  80
       */
        public static string print_top_view_nodes_with_while_solution(Tree<int> root) {

            var root_right = root;
            var root_left = root;

            var result_left =new  Stack();
            var result = string.Empty;

            if (root == null) return result;
          
            while (root_left.left != null)
            {
                result_left.Push(root_left.left.data);
                root_left = root_left.left;
            }

            while (result_left.Count != 0)
            {
                result += result_left.Pop() +" ";
            }

            result += root.data +" ";

            while (root_right.right != null)
            {
                result += root_right.right.data+" ";
                root_right = root_right.right;
            }

            return result;
        }

        /*         50
        *         /   \
        *        30    60
        *       /  \   / \
        *      20  40 55  70
        *                  \ 
        *                  80
        */
        public static string print_top_view_nodes_with_recursion(Tree<int> root)
        {
            var result = string.Empty;

            if (root == null) return result;

            var left_side = side_value_for_left(root.left);
            var right_side = side_value_for_right(root.right);

            result += left_side +root.data + " " + right_side;

            return result;
        }

        private static string side_value_for_left(Tree<int> root) {

            string result = string.Empty;
            if (root == null) return result;
            result = side_value_for_left(root.left);
            result += root.data + " ";

            return result;
        }

        private static string side_value_for_right(Tree<int> root)
        {

            string result = string.Empty;
            if (root == null) return result;

            result += root.data + " ";
            result += side_value_for_right(root.right);

            return result;
        }
    }
}
