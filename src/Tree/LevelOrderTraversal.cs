using CrackingCode.src.Tree.lib;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCode.src.Tree
{
    public static class LevelOrderTraversal
    {
       /*         50          level 1
       *         /   \
       *        30   60       level 2
       *       /  \    \
       *      20  40    70    level 3
       *                  \ 
       *                  80* level 4 
       *                  
       *  expected result "50 30 60 20 40 70 80"                
       */
        public static string print_level_order_traversal(Tree<int> root)
        {
            string result = "";

            if (root == null) return result;
            
            var set_result = levelOrder(root,1, new Dictionary<int, List<int>>());

            set_result.OrderBy(x => x.Key);

            set_result
            .Values
            .ToList()
            .ForEach(each_key => each_key.ForEach(each_value => result += each_value + " "));

            return result; 
        }
        public static Dictionary<int,List<int>> levelOrder(Tree<int> root
                                                          , int level 
                                                          , Dictionary<int , List<int>> result)
        {
            if (root == null) return result;

            if (result.Count < level) {
                result.Add(level, new List<int>());
            }
            result.FirstOrDefault(x => x.Key == level).Value.Add(root.data);
            result = levelOrder(root.left,level+1, result);
            result=  levelOrder(root.right,level+1,result);
            
            return result;
        }
    }

}
