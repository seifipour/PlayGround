using CrackingCode.src.Tree.lib;

namespace CrackingCode.src.Tree
{
    public static  class IsThisBinarySearchTreeScondSulotion
    {
        /*        50
       *         /   \
       *        30    60
       *       /  \    \
       *      20  40    70
       *           \      \ 
       *            48    80
       *          /         \
       *         45          90
       */


        public static bool is_this_binary_search_tree(Tree<int> root ) {

            if (root == null) return false;

            var min = int.MinValue;
            var max = int.MaxValue;

            var result = check_BST(root, min, max);
           
            return result;
        }

        public static bool check_BST(Tree<int> root, int min, int max ) {

            if (root == null) return true;
            if (root.data < min || root.data > max) {
                return false; 
            }
            return check_BST(root.left, min, root.data)
                    && check_BST(root.right, root.data, max);
        }
    }
}
