using CrackingCode.src.Tree.lib;

namespace CrackingCode.src.Tree
{
    public class IsT2ASubtreeOfT1
    {
        /*         50   (T1)               60   (T2)        
        *         /   \                   /  \
        *        30    60                65   70
        *       /  \   / \             
        *      20  40 65  70                                   
        *                  \                      
        *                   80                    
        *              
        */

        public static bool is_t2_subtree_of_t1(Tree<int> T1, Tree<int> T2) {

            if (T2 == null || T1 == null) return false;

            return find_t2_in_t1_and_compare_the_data(T1, T2);

        }
        public static bool find_t2_in_t1_and_compare_the_data(Tree<int> t1, Tree<int> t2) {

            if (t1 == null || t2 == null) return false ;
            if (t2.data == t1.data) return set_result(t1, t2);
            return find_t2_in_t1_and_compare_the_data(t1.left, t2) ||
                   find_t2_in_t1_and_compare_the_data(t1.right, t2);
        }

        public static bool set_result(Tree<int> t1, Tree<int> t2)
        {
            if (t2 == null || t1 == null) return true;

            if (t1.data != t2.data)
            {
                return false;
            }
            else
            {

                set_result(t1.left, t2.left);
                set_result(t1.right, t1.right);
            }
            return true;
        }
    }
}
