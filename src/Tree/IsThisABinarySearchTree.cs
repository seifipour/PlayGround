using CrackingCode.src.Tree.lib;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCode.src.Tree
{
    public static  class IsThisABinarySearchTree
    {
        /*          50
        *         /  \
        *        30   60
        *       /  \   \
        *      20  60   70
        *                \ 
        *                 80
        */
        public static bool is_this_binary_search_tree(Tree<int> root) {

            if (root == null) return false;
            var list_of_value = new List<int>();

            var convert_tree_to_list = convert_BST_to_list(root, list_of_value);

            var is_sorted = is_sorted_list(convert_tree_to_list);

            var no_duplicate = no_duplicat_value(convert_tree_to_list);

            if (!is_sorted || !no_duplicate) return false;

            return true;
        }

        public static List<int> convert_BST_to_list(Tree<int> root , List<int> result ) {

            if (root == null) return result;

            result = convert_BST_to_list(root.left, result);
            result.Add(root.data);
            result = convert_BST_to_list(root.right, result);

            return result;
        }

        public static bool is_sorted_list(List<int> result)
        {
            bool sorted = true;
            for (int i = 1; i < result.Count(); i++)
            {
                if (result.ElementAt(i - 1).CompareTo(result.ElementAt(i)) > 0) sorted = false;
            }

            return sorted;
        }

        public static bool no_duplicat_value(List<int> result)
        {
            var list_of_unique_value = new List<int>();

            for (int i = 0; i < result.Count(); i++)
            {
                if (list_of_unique_value.Contains(result.ElementAt(i)))
                {
                    return false;
                }
                else {

                    list_of_unique_value.Add(result.ElementAt(i));
                }
            }
            return true;
        }
    }
}
