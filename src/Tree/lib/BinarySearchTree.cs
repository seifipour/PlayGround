namespace CrackingCode.src.Tree.lib
{
    public class BinarySearchTree
    {
        public Tree<int> root;
        public BinarySearchTree(Tree<int> root)
        {
            this.root = root;
        }
       
        private void insert(Tree<int> tree, int data) {

                if (data < tree.data)
                {
                    if (tree.left != null)
                    {
                        insert(tree.left, data);
                    }
                    else
                    {
                        tree.left = new Tree<int>(data);
                    }
                }
                else
                {

                    if (tree.right != null)
                    {
                        insert(tree.right, data);
                    }
                    else
                    {
                        tree.right = new Tree<int>(data);
                    }
                }
        }

        private bool contain(Tree<int> tree, int data)
        {
            if (tree == null) return false;

            if (tree.data == data) return true;

            if (data < tree.data)
            {
                if (tree.left != null)
                {
                    insert(tree.left, data);
                }
            }
            else {

                if (tree.right != null)
                {
                    insert(tree.right, data);
                }
            }
            return false;
        }

        public void insert(int data) {
            insert(root, data);
        }

        public bool contain(int data) {

            return contain(root, data);
        }

    }


}
