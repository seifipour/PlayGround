using CrackingCode.src.Tree.lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCode.src.Tree
{
    public static class ConverSortedListToBinarySearchTree
    {
        /// <summary>
        ///    this method convert the list of sorted number to binary search tree .
        /// </summary>
        /// <param name="sorted_list">  {2 ,5,7,10,12}  </param>
        /// <param name="start"> 0</param>
        /// <param name="end"> 4 </param>
        /// <param name="root">null</param>
        /// <returns> Binary search tree </returns>
        /// 
        public static Tree<int> convert_sorted_list_to_binary_search_tree
                                    ( List<int> sorted_list , 
                                      decimal start ,
                                      decimal end , 
                                      Tree<int> root ) {

            if (end >= start)
            {
                int mid = (int)Math.Ceiling(start + (end - start) / 2);

                var root_data = sorted_list.ToList().ElementAt(mid);

                root = root.insert_data(root_data);
                convert_sorted_list_to_binary_search_tree(sorted_list, start, mid - 1, root);
                convert_sorted_list_to_binary_search_tree(sorted_list, mid + 1, end, root);
            }

            return root;
        }

        public static List<int> print_inorder_traversal(Tree<int> root, List<int> result) {

            if (root == null) return result;

            result = print_inorder_traversal(root.left,result);
            result.Add(root.data);
            result = print_inorder_traversal(root.right,result);

            return result;
        }

        public static Tree<int> insert_data(this Tree<int> root, int data ) {

            if (root == null) { root = new Tree<int>(data); return root; }

           if (data < root.data)
            {
                if (root.left != null)
                {
                    root.left.insert_data(data);
                }
                else
                {
                    root.left = new Tree<int>(data);
                    return root;
                }
            }
            else {
                if (root.right != null)
                {
                    root.right.insert_data( data);
                }
                else {
                    root.right = new Tree<int>(data);
                    return root;
                }

            }
            return root;
        }
    }
}
