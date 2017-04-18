using CrackingCode.src.Tree.lib;
using System.Collections.Generic;
using System.Linq;


namespace CrackingCode.src.Tree
{
    public static class CreateALinkedListForEachBinarySearchTreeDepth
    {
        public static Dictionary<int, CodeCrack.src.linkedlist.LinkedList<int>> return_list_of_linked_list_for_BST
                                                                                                ( Tree<int> root ) {
            if (root == null) return null;

            return set_result(root, 1, new Dictionary<int, CodeCrack.src.linkedlist.LinkedList<int>>());
        }

        public static  Dictionary<int, CodeCrack.src.linkedlist.LinkedList<int>> set_result (
                                                               Tree<int> root
                                                             , int level
                                                             , Dictionary<int, CodeCrack.src.linkedlist.LinkedList<int>> result) {

            if (root == null) return result;

            if (!result.ContainsKey(level))
            {
                result.Add(level, new CodeCrack.src.linkedlist.LinkedList<int>());
            }

          

            if (result.FirstOrDefault(x => x.Key == level).Value.head != null)

            {
                while (result.FirstOrDefault(x => x.Key == level).Value.head.next != null)
                {

                    result.FirstOrDefault(x => x.Key == level).Value.head =
                    result.FirstOrDefault(x => x.Key == level).Value.head.next;
                }

                result.FirstOrDefault(x => x.Key == level).Value.head.next =
                new CodeCrack.src.linkedlist.Node<int>(root.data);
            }
            else {

                result.FirstOrDefault(x => x.Key == level).Value.head =
                new CodeCrack.src.linkedlist.Node<int>(root.data);

            }

            result = set_result(root.left, level+1,result);

            result = set_result(root.right, level+1,result);

            return result;
        }
    }
} 
