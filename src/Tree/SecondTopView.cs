using CrackingCode.src.Tree.lib;
using System.Collections.Generic;
using System.Text;
using CodeCrack.src.linkedlist;

namespace CrackingCode.src.Tree
{
    /*         50*  (4)
    *         /    \
    *   (3) *30    60* (5)
    *       /  \   /  \
    * (2) *20  40 55  70*(6)
    *        \     \    \ 
    *       27      56  80* (7)
    *       /        \
    *      22         57
    *     /            \
    *(1)*21              58
    *                    \ 
    *                    59* (8)
    *  expected result string result = "21 20 30 50 60 70 80 59"                  
    */
    public class SecondTopView
    {
        public static string print_top_view_nodes_with_return_recursion(Tree<int> root)
        {
            var result =new StringBuilder();

            if (root == null) return result.ToString();

            var left_side = side_value_for_left_forward_recursion(
                                  root: root.left
                                 , sides: new Sides());

            var right_side = side_value_for_right_return_recurstion(
                                  root: root.right
                                , sides: new Sides());

            var new_tail = new Node<int>(root.data);
            left_side.tail.next = new_tail;
            left_side.tail = new_tail; 
            
            left_side.tail.next = right_side.head;

            while (left_side.head != null)
            {
                result.Append(left_side.head.data +" ");
                left_side.head = left_side.head.next;
            }

            return result.ToString();
        }

        private static CodeCrack.src.linkedlist.LinkedList<int> side_value_for_left_forward_recursion
                                                (Tree<int> root
                                                , Sides sides)
        {
            if (root == null) { sides.current -= 1; return sides.total_result; }

            if (sides.current > sides.max)
            {
                if (sides.total_result.head == null)
                {
                    sides.total_result.head = new Node<int>(root.data);
                    sides.total_result.tail = sides.total_result.head;
                }
                else {
                    var head= new Node<int>(root.data);
                    var temp= sides.total_result.head;
                    head.next = temp;
                    sides.total_result.head = head;

                }
                sides.max = sides.current;
            }
            sides.current += 1;
            side_value_for_left_forward_recursion(root.left, sides);

            sides.current -= 1;
            side_value_for_left_forward_recursion(root.right, sides);

            return sides.total_result;
        }
        

        private static CodeCrack.src.linkedlist.LinkedList<int> side_value_for_right_return_recurstion
                                               (Tree<int> root
                                                , Sides sides)
        { 
            if (root == null) { return sides.total_result; };

            if (sides.current > sides.max)
            {
                sides.total_result.append(root.data);

                sides.max = sides.current;
            }
            if (root.right != null)
            {
                sides.current += 1;
            }
            side_value_for_right_return_recurstion(root.right,sides);
            sides.current -= 1;
            side_value_for_right_return_recurstion(root.left,sides);

            return sides.total_result;
        }

        private static List<int> side_value_for_left_return_recursion
                                               (Tree<int> root
                                               , int max
                                               , int current)
        {
            var result = new List<int>();
            var total_result = new List<int>();

            if (root == null) return result;

            if (current > max)
            {
                result.Add(root.data);
                max = current;
            }

            total_result = side_value_for_left_return_recursion(root.left, max, current + 1);
            total_result
              .ForEach(each_reasult => { result.Add(each_reasult); });

            total_result = side_value_for_left_return_recursion(root.right, max, current - 1);
            total_result
               .ForEach(each_reasult => { result.Add(each_reasult); });

            return total_result;
        }


    }

    public class Sides {

        public int max { set; get; }
        public int current { get; set; }
        public CodeCrack.src.linkedlist.LinkedList<int> total_result { get; set; }
        public Sides()
        {
            max = 0;
            current = 1;
            total_result = new CodeCrack.src.linkedlist.LinkedList<int>();
        }
       
    }
    
}
